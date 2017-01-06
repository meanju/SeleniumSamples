using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumSamples.Framework
{
    public class MyFirefoxBrowser
    {
        private static IWebDriver driver;
        private static StringBuilder verificationErrors;
        private static string baseURL;
        private static bool acceptNextAlert = true;

        public static void SetBaseUrl(string url)
        {
            baseURL = url;
        }

        public static void GotoUrl(string v)
        {
            driver.Navigate().GoToUrl(baseURL + "/");
        }

        public static string GetTitle()
        {
            return driver.Title;
        }

        public static void Close()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }

        public static void Click(By by)
        {
            var element = driver.FindElement(by);
            element.Click();
        }

        public static void SetTextBoxValue(By by, string input)
        {
             var element = driver.FindElement(by);
            element.SendKeys(input);
        }

        public static void Initialize()
        {
            driver = new FirefoxDriver();
        }

        public static bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
