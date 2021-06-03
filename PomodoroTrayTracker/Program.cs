using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoomodoroTrayTracker
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Form1 form1 = new Form1();
            //ApplicationContext applicationContext = new ApplicationContext();
            //applicationContext.MainForm = form1;

            ApplicationContext applicationContext = new CustomApplicationContext();
            Application.Run(applicationContext);
        }
    }
}
