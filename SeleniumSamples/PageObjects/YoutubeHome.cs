using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SeleniumSamples.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumSamples.PageObjects
{
    public class YoutubeHome
    {
        

        public static void OpenPage()
        {
            MyFirefoxBrowser.Initialize();
            MyFirefoxBrowser.SetBaseUrl("https://www.youtube.com/");
            MyFirefoxBrowser.GotoUrl("/");
        }
        public static string Title()
        {
            return MyFirefoxBrowser.GetTitle();
        }

        public static void Close()
        {
            MyFirefoxBrowser.Close();
        }
    }
}
