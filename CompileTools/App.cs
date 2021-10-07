using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompileTools
{
    public class App
    {
        [STAThread]
        static void Main()
        {
            string[] arguments = System.Environment.GetCommandLineArgs();

            if (arguments.Length <= 1)
            {
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Window(arguments[1]));
        }
    }
}
