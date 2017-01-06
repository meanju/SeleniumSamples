using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumSamples.PageObjects;

namespace SeleniumSamples
{
    [TestClass]
    public class TestGoogleHome
    {
        /// <summary>
        /// This represents the actual test steps which otherwise is done manually
        /// 
        /// This is test case for checking Title of Google HomePage
        /// 
        /// Step 1. Open Google url
        /// Step 2. See Title
        /// Step 3. Verify that it is equal to "Google"
        /// </summary>
        [TestMethod]
        public void Test_Title()
        {
            GoogleHome.OpenPage();
            var title = GoogleHome.Title();
            Assert.AreEqual("Google", title );
        }

        [TestMethod]
        public void Test_Can_Enter_Text_In_Search_Box()
        {
            GoogleHome.OpenPage();
            var input = "Rocket";

            GoogleHome.EnterSearchText(input);

            System.Threading.Thread.Sleep(10000);
            //Assert.AreEqual("Google", title);
        }

        [TestMethod]
        public void Test_Can_Enter_Text_In_Search_Box_And_Click_Search()
        {
            GoogleHome.OpenPage();
            var input = "Rocket";

            GoogleHome.EnterSearchText(input);
            GoogleHome.ClickSearchIcon();
            System.Threading.Thread.Sleep(5000);
            Assert.IsTrue(GoogleHome.FindLink("Rocket - Wikipedia"),"Could not find Rocket wiki link");
            
        }


        [TestMethod]
        public void Test_Help_Link()
        {
            GoogleHome.OpenPage();
            GoogleHome.GoogleFooter.ClickAbout();
            System.Threading.Thread.Sleep(5000);
        }


        [TestCleanup]
        public void Test_Clean_Up()
        {
            GoogleHome.Close();
        }


    }
}
