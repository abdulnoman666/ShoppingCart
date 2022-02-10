using NUnit.Framework;
using OpenQA.Selenium;

namespace ContourSeleniumTest
    {
    internal partial class ShippingPage
        {
        private IWebDriver webDriver;

        public ShippingPage (IWebDriver webDriver)
            {
            this.webDriver = webDriver;
            }

        internal ShippingPage AssertShippingOptionDisplayedOnShippingPage (string desc)
            {
            string actual = HelperFunctions.GetElementText(DeliveryOptions);
            Assert.That(actual.Contains(desc), "Delivery option is not correct");
            return new ShippingPage(webDriver);
            }

        internal ShippingPage AssertErrorMessageDisplayedOnShippingPage (string desc)
            {
            string actual = HelperFunctions.GetElementText(FancyBoxError);
            Assert.That(actual.Contains(desc), "Fancy Box error is not displayed");
            return new ShippingPage(webDriver);
            }
        }
    }
