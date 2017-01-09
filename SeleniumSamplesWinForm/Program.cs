using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeleniumSamplesWinForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        public static void Main(string []args)
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            WorkingWithFirefox ff = new WorkingWithFirefox();
            ff.InvokeBrowser();
            ff.CloseAllBrowser();
            //Console.Read();
        }
    }
}
