using System;
using System.Web;
using System.Windows.Forms;

namespace Folder.Lock
{
    internal class Program
    {
        static Main main;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            main = new Main();
            Application.Run(main);
        }
    }
}