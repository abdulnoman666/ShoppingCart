using NUnit.Framework;

namespace ContourSeleniumTest
    {
    internal partial class ShoppingCartSummaryPage
        {
        internal void AssertShoppingCartSummaryDescription (string desc)
            {
            string Actualdescription = HelperFunctions.GetElementText(ShoppingCartSummaryDescription);

            StringAssert.Contains(desc, Actualdescription, "Expected:"+ desc + "Actual:"+ Actualdescription + "are not equal");
            }

        internal void AssertTabOnOrderStepOnShoppingCartSummaryPage (string desc)
            {
            string actual = HelperFunctions.GetElementText(OrderStep);

            Assert.That(actual.Contains(desc), "Tab cannot be validate on Order step with "+ desc + "Column name");
            }

        internal void AssertSummaryTabOnShoppingCartSummaryPage (string desc)
            {
            string actual = HelperFunctions.GetElementText(CartSummary);
            Assert.That(actual.Contains(desc), "Cart Summary Column cannot be validate on Shopping Cart Summary step");
            }

        internal void AssertOrderDeliveryOnShoppingCartSummaryPage (string desc)
            {
            string actual = HelperFunctions.GetElementText(OrderDelivery);
            Assert.That(actual.Contains(desc), "Order Detail Content cannot be validate on Order Summary step");
            }

        internal ShoppingCartSummaryPage AssertQuantityOnShoppingCartSummaryPage (string desc)
            {
            string actual = HelperFunctions.GetAttributeValue(desc);
            Assert.That(actual.Contains(desc), "Quantity cannot be validate on Order Summary step");
            return new ShoppingCartSummaryPage(webDriver);
            }

        internal void AssertDeleteIcon ()
            {
            Assert.That(DeleteIcon.Displayed, "Assert icon is not displayed");
            }
        }
    }
