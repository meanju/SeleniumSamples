using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumTests
{
    [TestClass]
    public class Googlesearch2
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [TestInitialize]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://www.google.com/";
            verificationErrors = new StringBuilder();
        }

        [TestCleanup]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [TestMethod]
        public void Validate_Title_Is_Google()
        {
            driver.Navigate().GoToUrl(baseURL + "/");
            var title = driver.Title;

            Assert.AreEqual(title, "Google");
        }

        [TestMethod]
        public void Validate_Btnk_Present_Google_Search()
        {
            driver.Navigate().GoToUrl(baseURL + "/");
            Assert.IsTrue(IsElementPresent(By.Name("btnK")));
        }

        [TestMethod]
        public void Validate_ABCD_Not_Present_Google_Search()
        {
            driver.Navigate().GoToUrl(baseURL + "/");
            Assert.IsFalse(IsElementPresent(By.Name("ABCD")));
        }



        /// <summary>
        /// The purpose of this method is to check if element is present or not
        /// </summary>
        /// <param name="by">By is a class which can take different parameters using which it can look 
        /// for elements</param>
        /// <returns></returns>
        private bool IsElementPresent(By by)
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

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
