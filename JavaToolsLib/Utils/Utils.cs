using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaToolsLib.Utils
{
    class Utils
    {
        public static string GetAbsoluteUri(string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);
            Uri uri = new Uri(fileInfo.FullName);
            return uri.AbsoluteUri;
        }
    }
}
