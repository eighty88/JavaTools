using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaToolsLib.Utils
{
    class Maven
    {
        public static string getMavenPath()
        {
            return Utils.GetAbsoluteUri("\\maven");
        }
    }
}
