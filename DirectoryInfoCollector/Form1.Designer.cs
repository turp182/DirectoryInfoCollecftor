namespace DirectoryInfoCollector
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtRootFolderPath = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResultFilePath = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTimeElapsed = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblFilesIdentified = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblFoldersProcessed = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblFoldersLeftToProcess = new System.Windows.Forms.Label();
            this.lblFolder = new System.Windows.Forms.Label();
            this.lblFoldersIdentified = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioCollectFolderSecurityDetails = new System.Windows.Forms.RadioButton();
            this.radioCollectFileDetails = new System.Windows.Forms.RadioButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.fileDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRootFolderPath
            // 
            this.txtRootFolderPath.Location = new System.Drawing.Point(44, 19);
            this.txtRootFolderPath.Name = "txtRootFolderPath";
            this.txtRootFolderPath.Size = new System.Drawing.Size(437, 20);
            this.txtRootFolderPath.TabIndex = 0;
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(12, 294);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(487, 40);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Folders Identified:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtRootFolderPath);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 46);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Root Folder To Analyze";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtResultFilePath);
            this.groupBox2.Location = new System.Drawing.Point(12, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 46);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results Output File Path (csv)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Path:";
            // 
            // txtResultFilePath
            // 
            this.txtResultFilePath.Location = new System.Drawing.Point(44, 19);
            this.txtResultFilePath.Name = "txtResultFilePath";
            this.txtResultFilePath.Size = new System.Drawing.Size(437, 20);
            this.txtResultFilePath.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTimeElapsed);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.lblFilesIdentified);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lblFoldersProcessed);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lblFoldersLeftToProcess);
            this.groupBox3.Controls.Add(this.lblFolder);
            this.groupBox3.Controls.Add(this.lblFoldersIdentified);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 193);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(487, 95);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Processing Status";
            // 
            // lblTimeElapsed
            // 
            this.lblTimeElapsed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTimeElapsed.Location = new System.Drawing.Point(370, 16);
            this.lblTimeElapsed.Name = "lblTimeElapsed";
            this.lblTimeElapsed.Size = new System.Drawing.Size(111, 20);
            this.lblTimeElapsed.TabIndex = 14;
            this.lblTimeElapsed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(254, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Time Elapsed (secs):";
            // 
            // lblFilesIdentified
            // 
            this.lblFilesIdentified.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFilesIdentified.Location = new System.Drawing.Point(370, 40);
            this.lblFilesIdentified.Name = "lblFilesIdentified";
            this.lblFilesIdentified.Size = new System.Drawing.Size(111, 20);
            this.lblFilesIdentified.TabIndex = 12;
            this.lblFilesIdentified.Text = "0";
            this.lblFilesIdentified.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(254, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Files Identified:";
            // 
            // lblFoldersProcessed
            // 
            this.lblFoldersProcessed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFoldersProcessed.Location = new System.Drawing.Point(131, 65);
            this.lblFoldersProcessed.Name = "lblFoldersProcessed";
            this.lblFoldersProcessed.Size = new System.Drawing.Size(111, 20);
            this.lblFoldersProcessed.TabIndex = 10;
            this.lblFoldersProcessed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Folders Processed:";
            // 
            // lblFoldersLeftToProcess
            // 
            this.lblFoldersLeftToProcess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFoldersLeftToProcess.Location = new System.Drawing.Point(131, 40);
            this.lblFoldersLeftToProcess.Name = "lblFoldersLeftToProcess";
            this.lblFoldersLeftToProcess.Size = new System.Drawing.Size(111, 20);
            this.lblFoldersLeftToProcess.TabIndex = 9;
            this.lblFoldersLeftToProcess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(6, 44);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(118, 13);
            this.lblFolder.TabIndex = 8;
            this.lblFolder.Text = "Folders Left to Process:";
            // 
            // lblFoldersIdentified
            // 
            this.lblFoldersIdentified.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFoldersIdentified.Location = new System.Drawing.Point(131, 16);
            this.lblFoldersIdentified.Name = "lblFoldersIdentified";
            this.lblFoldersIdentified.Size = new System.Drawing.Size(111, 20);
            this.lblFoldersIdentified.TabIndex = 7;
            this.lblFoldersIdentified.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioCollectFolderSecurityDetails);
            this.groupBox4.Controls.Add(this.radioCollectFileDetails);
            this.groupBox4.Location = new System.Drawing.Point(12, 116);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(487, 71);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Processing to Perform";
            // 
            // radioCollectFolderSecurityDetails
            // 
            this.radioCollectFolderSecurityDetails.AutoSize = true;
            this.radioCollectFolderSecurityDetails.Location = new System.Drawing.Point(6, 42);
            this.radioCollectFolderSecurityDetails.Name = "radioCollectFolderSecurityDetails";
            this.radioCollectFolderSecurityDetails.Size = new System.Drawing.Size(165, 17);
            this.radioCollectFolderSecurityDetails.TabIndex = 1;
            this.radioCollectFolderSecurityDetails.TabStop = true;
            this.radioCollectFolderSecurityDetails.Text = "Collect Folder Security Details";
            this.radioCollectFolderSecurityDetails.UseVisualStyleBackColor = true;
            // 
            // radioCollectFileDetails
            // 
            this.radioCollectFileDetails.AutoSize = true;
            this.radioCollectFileDetails.Location = new System.Drawing.Point(6, 19);
            this.radioCollectFileDetails.Name = "radioCollectFileDetails";
            this.radioCollectFileDetails.Size = new System.Drawing.Size(111, 17);
            this.radioCollectFileDetails.TabIndex = 0;
            this.radioCollectFileDetails.TabStop = true;
            this.radioCollectFileDetails.Text = "Collect File Details";
            this.radioCollectFileDetails.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // fileDetailsBindingSource
            // 
            this.fileDetailsBindingSource.DataSource = typeof(DirectoryInfoCollector.FileDetails);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 342);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Directory Information Collector";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtRootFolderPath;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource fileDetailsBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResultFilePath;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblTimeElapsed;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblFilesIdentified;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblFoldersProcessed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblFoldersLeftToProcess;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.Label lblFoldersIdentified;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioCollectFolderSecurityDetails;
        private System.Windows.Forms.RadioButton radioCollectFileDetails;
        private System.Windows.Forms.Timer timer;
    }
}

