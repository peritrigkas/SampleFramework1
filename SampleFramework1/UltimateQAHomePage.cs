using OpenQA.Selenium;

namespace SampleFramework1
{
    internal class UltimateQAHomePage
    {
        private IWebDriver driver;

        public UltimateQAHomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public bool IsVisible => driver.Title.Contains("Home - Ultimate QA");
    }
}