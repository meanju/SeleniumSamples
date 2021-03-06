﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace SeleniumSamplesWinForm
{
    public class WorkingWithFirefox
    {
        private IWebDriver driver = new FirefoxDriver();
        string url = "http://www.google.com";

        public void InvokeBrowser()
        {
            //To maximize the window
            driver.Manage().Window.Maximize();
           
            //To delete all the cookies of the browser
            driver.Manage().Cookies.DeleteAllCookies();

            //To navigate to the particular URL
            driver.Url = url;

            // To get the Title of the page
            var titleOfPage = driver.Title;

            Console.WriteLine("Title of the page is: " + titleOfPage);

            //To get The url of the page 
            var currentUrl = driver.Url;

            Console.Error.WriteLine("Title of the page is " + currentUrl);

            //To get The source code current page
            var pageSource = driver.PageSource;

            Console.WriteLine("Page Source" + pageSource);

        }

        //To close current active window of the browse
        public void CloseBrowser()
        {
            driver.Close();
        }

        //To close all the opened browser session
        public void CloseAllBrowser()
        {
            driver.Quit();
        }
    }
}
