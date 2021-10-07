using System;
using System.Collections.Generic;
using Microsoft.Win32;

namespace JavaToolsLib.RegistryLib
{
    public class JavaRegistry
    {

        const string olderPath = "Java Development Kit";
        const string newerPath = "JDK";

        const string jrePath = "Java Runtime Environment";

        public static string[] getJDKs()
        {
            List<string> list = new List<string>();

            RegistryKey localKey;
            if (Environment.Is64BitOperatingSystem)
                localKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
            else
                localKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);

            RegistryKey registryKey = localKey.OpenSubKey(@"SOFTWARE\JavaSoft\" + olderPath);
            if (registryKey != null)
            {
                foreach (string str in registryKey.GetSubKeyNames())
                {
                    list.Add(str + "$" + (string) localKey.OpenSubKey(@"SOFTWARE\JavaSoft\" + olderPath + @"\" + str).GetValue("JavaHome"));
                }

                registryKey.Close();
            }

            registryKey = localKey.OpenSubKey(@"SOFTWARE\JavaSoft\" + newerPath);
            if (registryKey != null)
            {
                foreach (string str in registryKey.GetSubKeyNames())
                {
                    list.Add(str + "$" + (string)localKey.OpenSubKey(@"SOFTWARE\JavaSoft\" + newerPath + @"\" + str).GetValue("JavaHome"));
                }

                registryKey.Close();
            }

            return list.ToArray();
        }

        public static string[] getJREs()
        {
            List<string> list = new List<string>();

            RegistryKey localKey;
            if (Environment.Is64BitOperatingSystem)
                localKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
            else
                localKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);

            RegistryKey registryKey = localKey.OpenSubKey(@"SOFTWARE\JavaSoft\" + jrePath);
            if (registryKey != null)
            {
                foreach (string str in registryKey.GetSubKeyNames())
                {
                    list.Add(str + "$" + (string)localKey.OpenSubKey(@"SOFTWARE\JavaSoft\" + jrePath + @"\" + str).GetValue("JavaHome"));
                }

                registryKey.Close();
            }

            return list.ToArray();
        }
    }
}
