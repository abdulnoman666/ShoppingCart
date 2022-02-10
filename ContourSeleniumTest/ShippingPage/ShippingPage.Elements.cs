using OpenQA.Selenium;

namespace ContourSeleniumTest
    {
    internal partial class ShippingPage
        {
        IWebElement DeliveryOptions => webDriver.FindElement(By.ClassName("delivery_options"));
        IWebElement TermsOfServiceCheckbox => webDriver.FindElement(By.Id("cgv"));
        IWebElement ProceedToCheckoutBtn => webDriver.FindElement(By.XPath("//button[@name='processCarrier']"));
        IWebElement FancyBoxError => webDriver.FindElement(By.ClassName("fancybox-error"));
        IWebElement CloseBtn => webDriver.FindElement(By.XPath("//a[@title='Close']"));
        }
    }
