using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumSamplesWinForm
{
    public class WorkingWithFirefox
    {
        private IWebDriver driver = new FirefoxDriver();
        string url = "http://www.google.com";

        public void InvokeBrowser()
        {
            driver.Manage().Window.Maximize();

            driver.Manage().Cookies.DeleteAllCookies();

            driver.Url = url;

            var titleOfPage = driver.Title;

            Console.WriteLine("Title of the page is: " + titleOfPage);

            var currentUrl = driver.Url;

            Console.Error.WriteLine("Title of the page is " + currentUrl);

            var pageSource = driver.PageSource;

            Console.WriteLine("Page Source" + pageSource);

        }

        public void CloseBrowser()
        {
            driver.Close();
        }

        public void CloseAllBrowser()
        {
            driver.Quit();
        }
    }
}
