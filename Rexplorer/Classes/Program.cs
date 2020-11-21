using Rexplorer.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rexplorer {
    static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new ReProcess();
            Application.Run(new MainForm());
        }
    }
}
