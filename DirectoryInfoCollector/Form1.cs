using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Threading;
using System.Windows.Forms;

namespace DirectoryInfoCollector
{
    public partial class Form1 : Form
    {
        #region Fields (private)

        private List<string> _folders = new List<string>();
        private string _outputFileName = string.Empty;
        private bool _getFileDetails = false;
        private bool _getFolderSecurityDetails;
        private DateTime _startTime;

        #endregion

        #region Constructor

        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Private Control Events

        private void btnGo_Click(object sender, EventArgs e)
        {
            _startTime = DateTime.Now;

            if (!Directory.Exists(txtRootFolderPath.Text))
            {
                MessageBox.Show("Root Folder Path Doesn't Exist...");
                return;
            }

            if (File.Exists(txtResultFilePath.Text))
            {
                MessageBox.Show("Results File Already Exists, Processing Ended...");
                return;
            }

            if (!Directory.Exists(Path.GetDirectoryName(txtResultFilePath.Text)))
            {
                MessageBox.Show("Output File Folder Path Doesn't Exist, Processing Ended...");
                return;
            }

            if (!radioCollectFileDetails.Checked && !radioCollectFolderSecurityDetails.Checked)
            {
                MessageBox.Show("Please Select a Processing Method to Perform...");
                return;
            }

            lblFilesIdentified.Text = "0";
            lblTimeElapsed.Text = string.Empty;

            timer.Enabled = true;

            _outputFileName = txtResultFilePath.Text;

            if (radioCollectFileDetails.Checked)
            {
                _getFileDetails = true;

                using (StreamWriter writer = File.AppendText(_outputFileName))
                {
                    writer.WriteLine(FileDetails.FILE_DETAILS_FIELD_LIST);
                }
            }
            else
            {
                _getFolderSecurityDetails = true;

                using (StreamWriter writer = File.AppendText(_outputFileName))
                {
                    // TODO
                    writer.WriteLine(FolderSecurityDetails.FOLDER_SECURITY_DETAILS_FIELD_LIST);
                }
            }

            _folders.Add(txtRootFolderPath.Text);
            UpdateFoldersIdentifiedCount();
            UpdateFolersLeftToProcessCount();

            RecurseDirectories(txtRootFolderPath.Text);

            if (_getFileDetails)
            {
                while (_folders.Count > 0)
                {
                    GetFileDetails(_folders[0]);
                    _folders.RemoveAt(0);
                    UpdateFolersLeftToProcessCount();
                }
            }
            else if (_getFolderSecurityDetails)
            {
                while (_folders.Count > 0)
                {
                    GetFolderSecurityDetails(_folders[0]);
                    _folders.RemoveAt(0);
                    UpdateFolersLeftToProcessCount();
                }
            }

            timer.Enabled = false;

            MessageBox.Show("Finished...");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            double elapsedSeconds = DateTime.Now.Subtract(_startTime).TotalSeconds;
            lblTimeElapsed.Text = elapsedSeconds.ToString(elapsedSeconds.ToString("N0"));
            lblTimeElapsed.Invalidate();
            lblTimeElapsed.Update();
            lblTimeElapsed.Refresh();
            Application.DoEvents();
        }

        #endregion

        #region Methods (private)

        private void GetFileDetails(string path)
        {
            List<string> files;

            try
            {
                files = Directory.GetFiles(path).ToList();
            }
            catch (UnauthorizedAccessException exc)
            {
                FileDetails details = new FileDetails();
                details.Error = "Exception - Folder Access Exception";
                details.Path = path;
                SaveFileDetailsToFile(details);
                return;
            }
            catch (DirectoryNotFoundException exc)
            {
                FileDetails details = new FileDetails();
                details.Error = "Exception - Directory Not Found";
                details.Path = path;
                SaveFileDetailsToFile(details);
                return;
            }

            foreach (string file in files)
            {
                FileDetails details = new FileDetails();

                try
                {
                    details.Name = Path.GetFileName(file);
                    details.Path = Path.GetFullPath(file);
                    FileInfo fileInfo = new FileInfo(file);
                    details.SizeInBytes = fileInfo.Length;
                    details.CreationDate = fileInfo.CreationTime;
                    details.LastAccessDate = fileInfo.LastAccessTime;
                    details.LastModifiedDate = fileInfo.LastWriteTime;

                    SaveFileDetailsToFile(details);

                    long fileCount = Convert.ToInt64(lblFilesIdentified.Text.Replace(",", string.Empty));

                    lblFilesIdentified.Text = (fileCount + 1).ToString("N0");

                }
                catch (PathTooLongException exc)
                {
                    FileDetails fileDetails = new FileDetails();
                    fileDetails.Error = "Exception: Path Too Long Exception: ";
                    fileDetails.Path = file;
                    SaveFileDetailsToFile(details);

                }
            }
        }

        private void SaveFileDetailsToFile(FileDetails details)
        {
            using (StreamWriter writer = File.AppendText(_outputFileName))
            {
                writer.WriteLine(details.ToCsvFormattedString());
            }
        }

        private void GetFolderSecurityDetails(string path)
        {
            DirectorySecurity dirSec = null;

            try
            {
                dirSec = Directory.GetAccessControl(path);
            }
            catch (UnauthorizedAccessException exc)
            {
                FolderSecurityDetails details = new FolderSecurityDetails()
                {
                    Path = path,
                    Error = "Unauthroized Access Exception"
                };

                SaveFolderSecurityDetailsToFile(details);
                return;
            }

            AuthorizationRuleCollection authColl = dirSec.GetAccessRules(true, true, typeof(System.Security.Principal.NTAccount));

            foreach (AuthorizationRule authRule in authColl)
            {
                AccessRule accessRule = authRule as AccessRule;

                FolderSecurityDetails details = new FolderSecurityDetails()
                {
                    Path = path,
                    IdentityReference = accessRule.IdentityReference.Value,
                    InheritanceFlags = accessRule.InheritanceFlags.ToString(),
                    IsInherited = accessRule.IsInherited,
                    PropagationFlags = accessRule.PropagationFlags.ToString(),
                    AccessControlType = accessRule.AccessControlType.ToString()
                };

                SaveFolderSecurityDetailsToFile(details);
            }
        }

        private void SaveFolderSecurityDetailsToFile(FolderSecurityDetails details)
        {
            using (StreamWriter writer = File.AppendText(_outputFileName))
            {
                writer.WriteLine(details.ToCsvFormattedString());
            }
        }

        private void RecurseDirectories(string path)
        {
            try
            {

                List<string> directories = Directory.GetDirectories(path).ToList();

                foreach (string directory in directories)
                {
                    _folders.Insert(0, directory);
                    UpdateFoldersIdentifiedCount();
                    UpdateFolersLeftToProcessCount();
                    
                    RecurseDirectories(directory);
                }
            }
            catch (UnauthorizedAccessException exc)
            {
                if (_getFileDetails)
                {
                    FileDetails details = new FileDetails();
                    details.Error = "Exception - Folder Access Exception";
                    details.Path = path;
                    SaveFileDetailsToFile(details);
                }
                else if (_getFolderSecurityDetails)
                {
                    FolderSecurityDetails details = new FolderSecurityDetails();
                    details.Error = "Exception - Folder Access Exception";
                    details.Path = path;
                    SaveFolderSecurityDetailsToFile(details);
                }
            }
        }

        #endregion

        #region Private Counter Update Methods

        private void UpdateFoldersIdentifiedCount()
        {
            lblFoldersIdentified.Text = _folders.Count.ToString("N0");
            lblFoldersIdentified.Invalidate();
            lblFoldersIdentified.Update();
            lblFoldersIdentified.Refresh();
            Application.DoEvents();
        }

        private void UpdateFolersLeftToProcessCount()
        {
            lblFoldersLeftToProcess.Text = _folders.Count.ToString("N0");
            lblFoldersLeftToProcess.Invalidate();
            lblFoldersLeftToProcess.Update();
            lblFoldersLeftToProcess.Refresh();

            long foldersProcessed = Convert.ToInt32(lblFoldersIdentified.Text.Replace(",", string.Empty)) - Convert.ToInt32(lblFoldersLeftToProcess.Text.Replace(",", string.Empty));
            lblFoldersProcessed.Text = foldersProcessed.ToString("N0");
            lblFoldersProcessed.Invalidate();
            lblFoldersProcessed.Update();
            lblFoldersProcessed.Refresh();

            Application.DoEvents();
        }

        #endregion

    }
}
