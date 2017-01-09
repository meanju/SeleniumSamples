using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeleniumSamplesWinForm
{
    static class Program
    {
        private static object ff;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static void Main(string []args)
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
           // WorkingWithChrome chrome = new WorkingWithChrome();
           // chrome.InvokeBrowser();
           //chrome.CloseAllBrowser();

           // WorkingWithFirefox firefox = new WorkingWithFirefox();
           // firefox.InvokeBrowser();
           // firefox.CloseAllBrowser();
           // Console.Read();

            WorkingWithIE ie = new WorkingWithIE();
            ie.InvokeBrowser();
            ie.CloseAllBrowser();
            Console.Read();
        }
    }
}
