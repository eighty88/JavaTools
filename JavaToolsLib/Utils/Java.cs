﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaToolsLib.Utils
{
    class Java
    {
        public static string getDefaultPath()
        {
            return Utils.GetAbsoluteUri("\\jdk");
        }
    }
}
