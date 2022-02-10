using NUnit.Framework;
using OpenQA.Selenium;

namespace ContourSeleniumTest
    {
    internal partial class PaymentPage
        {
        private IWebDriver webDriver;

        public PaymentPage (IWebDriver webDriver)
            {
            this.webDriver = webDriver;
            }

        internal PaymentPage AssertPaymentTabOnPaymentPage (string desc)
            {
            string actual = HelperFunctions.GetElementText(CartSummary);
            Assert.That(actual.Contains(desc), "Cart Summary Column cannot be validate on Payment page");
            return new PaymentPage(webDriver);
            }

        internal PaymentPage AssertDescriptionOnBankWirePaymentPage (string desc)
            {
            string actual = HelperFunctions.GetElementText(BankWirePaymentForm);

            Assert.That(actual.Contains(desc), "Description cannot be validate on Payment step with " + desc);
            return new PaymentPage(webDriver);
            }

        internal PaymentPage AssertOrderConfirmationOnPaymentPage (string desc)
            {
            string actual = HelperFunctions.GetElementText(OrderConfirmationBox);

            Assert.That(actual.Contains(desc), "Description cannot be validate on Order Confirmation Page ");
            return new PaymentPage(webDriver);
            }
        }
    }
