using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DirectoryInfoCollector
{
    public class FileDetails
    {
        public static readonly string FILE_DETAILS_FIELD_LIST = "Name,Path,SizeInBytes,CreationDate,LastModifiedDate,LastAccessDate";

        public string Name { get; set; }

        public string Path { get; set; }

        public long SizeInBytes { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public DateTime LastAccessDate { get; set; }

        public string Error { get; set; }

        public FileDetails()
        {
            Name = string.Empty;
            Path = string.Empty;
            Error = string.Empty;
        }

        public string ToCsvFormattedString()
        {
            string retVal = string.Empty;

            retVal += "\"" + Name.Replace("\"", "\"\"") + "\",";
            retVal += "\"" + Path.Replace("\"", "\"\"") + "\",";
            retVal += "\"" + SizeInBytes + "\",";
            retVal += "\"" + CreationDate.ToShortDateString() + "\",";
            retVal += "\"" + LastModifiedDate.ToShortDateString() + "\",";
            retVal += "\"" + LastAccessDate.ToShortDateString() + "\",";
            retVal += "\"" + Error.Replace("\"", "\"\"") + "\"";

            return retVal;
        }

    }
}
