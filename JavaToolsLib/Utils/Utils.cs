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
            string path = Directory.GetCurrentDirectory();

            var URL = new Uri(@path);
            return new Uri(URL, @filePath).LocalPath;
        }
    }
}
