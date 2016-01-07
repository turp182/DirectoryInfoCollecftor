using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DirectoryInfoCollector
{
    public class FolderSecurityDetails
    {
        public static readonly string FOLDER_SECURITY_DETAILS_FIELD_LIST = "Path,IdentityReference,InheritanceFlags,IsInherited,PropagationFlags,AccessControlType,Error";

        public string Path { get; set; }

        public string IdentityReference { get; set; }

        public string InheritanceFlags { get; set; }
        public bool IsInherited { get; set; }

        public string PropagationFlags { get; set; }

        public string AccessControlType { get; set; }

        public string Error { get; set; }

        public FolderSecurityDetails()
        {
            Path = string.Empty;
            IdentityReference = string.Empty;
            InheritanceFlags = string.Empty;
            PropagationFlags = string.Empty;
            AccessControlType = string.Empty;
            Error = string.Empty;
        }

        public string ToCsvFormattedString()
        {
            string retVal = string.Empty;

            retVal += "\"" + Path.Replace("\"", "\"\"") + "\",";
            retVal += "\"" + IdentityReference.Replace("\"", "\"\"") + "\",";
            retVal += "\"" + InheritanceFlags.Replace("\"", "\"\"") + "\",";
            retVal += "\"" + IsInherited.ToString() + "\",";
            retVal += "\"" + PropagationFlags.Replace("\"", "\"\"") + "\",";
            retVal += "\"" + AccessControlType.Replace("\"", "\"\"") + "\",";
            retVal += "\"" + Error.Replace("\"", "\"\"") + "\"";

            return retVal;
        }



    }
}
