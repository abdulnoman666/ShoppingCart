namespace ContourSeleniumTest
    {
    internal partial class AddressesPage
        {
        internal AddressesPage EnterCommentsOnAddressesPage (string desc)
            {
            HelperFunctions.EnterValue(CommentSection, desc);
            return new AddressesPage(webDriver);
            }

        internal ShippingPage ClickProceedToCheckoutButtonOnAddressesPage ()
            {
            HelperFunctions.ClickElement(ProceedToCheckoutBtn);
            return new ShippingPage(webDriver);
            }

        internal AddressesPage ClickUpdateButtonBillingAddress ()
            {
            HelperFunctions.ClickElement(UpdateDeliveryAddressBtn);
            return new AddressesPage(webDriver);
            }

        internal AddressesPage EnterBillingAddress (string value)
            {
            HelperFunctions.EnterValue(AddressFld, value);
            return new AddressesPage(webDriver);
            }

        internal AddressesPage ClickSaveButtonOnAddressPage ()
            {
            HelperFunctions.ClickElement(SaveButton);
            return new AddressesPage(webDriver);
            }

        }
    }
