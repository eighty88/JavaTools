using System;
using System.Collections.Generic;
using Microsoft.Win32;

namespace JavaToolsLib.RegistryLib
{
    class JavaRegistry
    {

        const string olderPath = "Java Development Kit";
        const string newerPath = "JDK";

        const string jrePath = "\\Java Runtime Environment";

        public static string[] getJDKs()
        {
            List<string> list = new List<string>();

            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\JavaSoft\" + olderPath);
            if (registryKey != null)
            {
                foreach (string str in registryKey.GetSubKeyNames())
                {
                    list.Add((string) Registry.CurrentUser.OpenSubKey(@"SOFTWARE\JavaSoft\" + olderPath + @"\" + str).GetValue("JavaHome"));
                }
            }

            registryKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\JavaSoft\" + newerPath);
            if (registryKey != null)
            {
                foreach (string str in registryKey.GetSubKeyNames())
                {
                    list.Add((string)Registry.CurrentUser.OpenSubKey(@"SOFTWARE\JavaSoft\" + newerPath + @"\" + str).GetValue("JavaHome"));
                }
            }

            return list.ToArray();
        }

        public static string[] getJREs()
        {
            List<string> list = new List<string>();

            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\JavaSoft\" + jrePath);
            if (registryKey != null)
            {
                foreach (string str in registryKey.GetSubKeyNames())
                {
                    list.Add((string)Registry.CurrentUser.OpenSubKey(@"SOFTWARE\JavaSoft\" + jrePath + @"\" + str).GetValue("JavaHome"));
                }
            }

            return list.ToArray();
        }
    }
}
