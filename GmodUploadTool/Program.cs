using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Diagnostics;
namespace GmodUploadTool
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //SRE.ExtractResFile("GmodUploadTool.Resources.MetroSet UI.dll", Application.StartupPath + "/MetroSet UI.dll");
            Application.Run(new SRE());
            

        }

    }
}

