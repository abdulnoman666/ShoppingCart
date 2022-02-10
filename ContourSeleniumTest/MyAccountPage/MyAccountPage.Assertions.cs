using OpenQA.Selenium;

namespace ContourSeleniumTest
    {
    internal partial class MyAccountPage
        {
        private IWebDriver webDriver;

        public MyAccountPage (IWebDriver webDriver)
            {
            this.webDriver = webDriver;
            }
        }
    }
