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
    public class GoogleHome
    {
       

        public static void OpenPage()
        {
            MyFirefoxBrowser.Initialize();
            MyFirefoxBrowser.SetBaseUrl("https://www.google.com/");
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

        public static void EnterSearchText(string input)
        {
            
            MyFirefoxBrowser.SetTextBoxValue(By.Name("q"),input);
        }

        public static void ClickSearchIcon()
        {
            MyFirefoxBrowser.Click(By.Name("btnG"));
        }

        public static bool FindLink(string v)
        {
            return MyFirefoxBrowser.IsElementPresent(By.LinkText(v)); 
        }

        public static Footer GoogleFooter { get { return new Footer(); } }
    }

    public  class Footer
    {
        public void ClickAbout()
        {
            MyFirefoxBrowser.Click(By.LinkText("About"));
        }

    }
}
