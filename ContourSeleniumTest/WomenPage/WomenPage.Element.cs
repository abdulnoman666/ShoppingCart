using OpenQA.Selenium;

namespace ContourSeleniumTest
    {
    internal partial class WomenPage
        {
        private IWebDriver webDriver;

        public WomenPage (IWebDriver webDriver)
            {
            this.webDriver = webDriver;
            }
        IWebElement AddToCartBtn => webDriver.FindElement(By.XPath("//a[@title='Add to cart']"));
        IWebElement PopupPage => webDriver.FindElement(By.XPath("//div[@class='clearfix']"));
        IWebElement ProceedToCheckoutBtn => webDriver.FindElement(By.XPath("//a[@title='Proceed to checkout']"));
        }
    }
