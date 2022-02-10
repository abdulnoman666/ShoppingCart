using OpenQA.Selenium;

namespace ContourSeleniumTest
    {
    internal partial class MyAccountPage
        {
        IWebElement CartDropdown => webDriver.FindElement(By.PartialLinkText("Cart"));
        }
    }
