using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumSamplesWinForm
{
    public class WorkingWithChrome
    {
        private IWebDriver ChromeDriver = new ChromeDriver();
        string url = "http://www.youtube.com";

        public void InvokeBrowser()
        {
            ChromeDriver.Manage().Window.Maximize();
            ChromeDriver.Manage().Cookies.DeleteAllCookies();
            ChromeDriver.Url = url;
            var titleOfPage = ChromeDriver.Title;
            Console.WriteLine("Title of the page is: " + titleOfPage);

            var currentUrl = ChromeDriver.Url;
            Console.Error.WriteLine("The title of the url is: " + currentUrl);

            var pageSource = ChromeDriver.PageSource;

            Console.WriteLine("Page Source" + pageSource);
        }

        public void CloseBrowser()
        {
            ChromeDriver.Close();
        }

        public void CloseAllBrowser()
        {
            ChromeDriver.Quit();
        }

    }
}
