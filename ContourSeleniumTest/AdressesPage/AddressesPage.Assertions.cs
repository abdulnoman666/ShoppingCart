using NUnit.Framework;

namespace ContourSeleniumTest
    {
    internal partial class AddressesPage
        {
        internal AddressesPage AssertDeliveryAddressOnAddressesPage (string desc)
            {
            string actual = HelperFunctions.GetElementText(DeliveryAddressDropdown);
            Assert.That(actual.Contains(desc), "Delivery Address on Address page cannot be validated");
            return new AddressesPage(webDriver);
            }

        internal AddressesPage AssertUseDeliveryAddressAsBillingAddressCheckboxSelectedOnAddressesPage ()
            {
            Assert.That(UseDeliveryAddressAsBillingAddressCheckbox.Enabled, "Use Delivery Address as Billing Address is not selected" +
                "on Addresses page");
            return new AddressesPage(webDriver);
            }

        internal AddressesPage AssertAddressesOnAddressesPage (string desc)
            {
            string actual = HelperFunctions.GetElementText(OrderDelivery);
            Assert.That(actual.Contains(desc), "Addresses cannot be validate on Adresses page");
            return new AddressesPage(webDriver);
            }

        internal void AssertUpdateLinkDisplayedOnAddressesPage ()
            {
            Assert.That(UpdateLink.Displayed, "Update Link is not displayed on Addresses page");
            }
        }
    }
