using System;
using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SampleFramework1
{
    [TestClass]
    [TestCategory("SampleApplicationOne")]
    public class SampleApplicationOne
    {
        //private IWebDriver driver;

        public IWebDriver Driver { get ; set ; }

        [TestMethod]
        public void TestMethod1()
        {
            Driver = GetChromeDriver();
            var sampleApplicationPage = new SampleApplicationPage(Driver);
            sampleApplicationPage.GoTo();
            Assert.IsTrue(sampleApplicationPage.IsVisible);

            var ultimateQAHomePage = sampleApplicationPage.FillOutFormAndSubmit("Peri");
            Assert.IsTrue(ultimateQAHomePage.IsVisible);
        }

        private IWebDriver GetChromeDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory);
        }
    }
}
