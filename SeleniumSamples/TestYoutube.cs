using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumSamples.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumSamples
{
    [TestClass]
    public class TestYoutube
    {
        [TestMethod]
        public void Test_Youtube_Title()
        {
            YoutubeHome.OpenPage();
            var title = YoutubeHome.Title();

            Assert.AreEqual(title, "YouTube");
        }

        [TestCleanup]
        public void Test_Clean_Up()
        {
            YoutubeHome.Close();
        }
    }
}
