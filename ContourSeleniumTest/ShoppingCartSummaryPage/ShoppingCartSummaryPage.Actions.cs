namespace ContourSeleniumTest
    {
    internal partial class ShoppingCartSummaryPage
        {
        internal WomenPage ClickWomenLinkOnShoppingSummaryPage ()
            {
            HelperFunctions.ClickElement(WomenTextLink);
            return new WomenPage(webDriver);
            }

        internal AddressesPage ClickProceedToCheckoutButtonOnShoppingSummaryPage ()
            {
            HelperFunctions.ClickElement(ProceedToCheckoutBtn);
            AddressesPage pageAddress = new AddressesPage(webDriver);
            pageAddress.AssertUpdateLinkDisplayedOnAddressesPage();
            return new AddressesPage(webDriver);
            }

        internal ShoppingCartSummaryPage ClickPlusButtonOnShoppingCartSummaryPage()
            {
            HelperFunctions.ClickElement(PlusButton);
            return new ShoppingCartSummaryPage(webDriver);
            }
        }
    }
