namespace ContourSeleniumTest
    {
    internal partial class ShippingPage
        {
        internal ShippingPage ClickTermsOfServiceCheckboxOnShippingPage ()
            {
            HelperFunctions.ClickElement(TermsOfServiceCheckbox);
            return new ShippingPage(webDriver);
            }

        internal PaymentPage ClickProceedToCheckoutButtonOnAddressesPage ()
            {
            HelperFunctions.ClickElement(ProceedToCheckoutBtn);
            return new PaymentPage(webDriver);
            }

        internal ShippingPage ClickProceedToCheckoutButtonOnAddressesPage (bool flag)
            {
            HelperFunctions.ClickElement(ProceedToCheckoutBtn);
            return new ShippingPage(webDriver);
            }

        internal ShippingPage ClickCloseButtonOnErrorMessage ()
            {
            HelperFunctions.ClickElement(CloseBtn);
            return new ShippingPage(webDriver);
            }
        }
    }
