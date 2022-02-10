
using OpenQA.Selenium;

namespace ContourSeleniumTest
    {
    internal partial class ShoppingCartSummaryPage
        {
        private IWebDriver webDriver;

        internal ShoppingCartSummaryPage (IWebDriver webDriver)
            {
            this.webDriver = webDriver;
            }
        IWebElement ShoppingCartSummaryDescription => webDriver.FindElement(By.Id("center_column"));
        IWebElement WomenTextLink => webDriver.FindElement(By.LinkText("Women"));
        IWebElement OrderStep => webDriver.FindElement(By.Id("order_step"));
        IWebElement CartSummary => webDriver.FindElement(By.Id("cart_summary"));
        IWebElement DeleteIcon => webDriver.FindElement(By.XPath("//a[@title='Delete']"));
        IWebElement OrderDelivery => webDriver.FindElement(By.Id("center_column"));
        IWebElement ProceedToCheckoutBtn => webDriver.FindElement(By.LinkText("Proceed to checkout"));
        IWebElement PlusButton => webDriver.FindElement(By.ClassName("icon-plus"));
        IWebElement QuantityFld => webDriver.FindElement(By.XPath("//input[@value='2']"));
        }
    }
