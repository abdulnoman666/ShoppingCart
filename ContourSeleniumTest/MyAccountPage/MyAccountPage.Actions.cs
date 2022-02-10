namespace ContourSeleniumTest
    {
    internal partial class MyAccountPage
        {
        internal ShoppingCartSummaryPage ClickCartDropdownOnMyAccountPage (string desc)
            {
            HelperFunctions.ClickElement(CartDropdown);

            ShoppingCartSummaryPage pageShoppingSummary = new ShoppingCartSummaryPage(webDriver);
            pageShoppingSummary.AssertShoppingCartSummaryDescription(desc);

            return new ShoppingCartSummaryPage(webDriver);
            }
        }
    }
