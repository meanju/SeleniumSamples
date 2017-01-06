using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumSamples.Framework;
using System.Collections.Generic;

namespace SeleniumSamples
{
    [TestClass]
    public class Test_TestCasesFromString
    {
        [TestMethod]
        public void Test_Two_Lines_Of_Test_Cases()
        {
            var testCases = new[] { "TestCase1,http://www.google.com,/,Title,Google",
                "TestCase2,http://www.youtube.com,/,Title,YouTube"};

            var testResults = new List<string>();
            foreach(var line in testCases)
            {
                var testCase = line.Split(",".ToCharArray());
                var testCaseName = testCase[0];
                var url = testCase[1];
                var gotoUrl = testCase[2];
                var title = testCase[3];
                var result = testCase[4];

                MyFirefoxBrowser.Initialize();
                MyFirefoxBrowser.SetBaseUrl(url);
                MyFirefoxBrowser.GotoUrl(gotoUrl);
                var titleFromBrowser = MyFirefoxBrowser.GetTitle();
                MyFirefoxBrowser.Close();
                var passOrFail = "";
                if (title == titleFromBrowser)
                {
                    passOrFail = "Pass";
                }
                
                else passOrFail = "Fail";
                testResults.Add("Test case : " + testCaseName + " " + passOrFail);
            }
            foreach (var result in testResults)
                Console.WriteLine(result);
        }
    }
}
