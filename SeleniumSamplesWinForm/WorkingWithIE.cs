using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumSamplesWinForm
{
    class WorkingWithIE
    {
        private IWebDriver driver = new InternetExplorerDriver();
        string url = "http://www.bing.com";

        public void InvokeBrowser()
        {
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Url = url;
            var titleOfPage = driver.Title;
            Console.WriteLine("Title of the page is: " + titleOfPage);

            var currentUrl = driver.Url;
            Console.Error.WriteLine("The title of the url is: " + currentUrl);

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

