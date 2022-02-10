using OpenQA.Selenium;

namespace ContourSeleniumTest
    {
    internal partial class WomenPage
        {
        internal WomenPage TakeMouseOnItemOfChoiceOnWomenPage (string title)
            {
            HelperFunctions.TakeMouseOnItemOfChoice(title);
            return new WomenPage(webDriver);
            }

        internal WomenPage ClickAddToCartButtonOnWomenPage ()
            {
            HelperFunctions.ClickElement(AddToCartBtn);
            HelperFunctions.WaitForSeconds(5);
            AssertProductAddedShoppingCartOnWomenPage("Product successfully added to your shopping cart");
            return new WomenPage(webDriver);
            }

        internal ShoppingCartSummaryPage ClickProceedToCheckoutButtonOnWomenPage ()
            {
            HelperFunctions.ClickElement(ProceedToCheckoutBtn);

            ShoppingCartSummaryPage pageShoppingCartSummary = new ShoppingCartSummaryPage(webDriver);
            pageShoppingCartSummary.AssertTabOnOrderStepOnShoppingCartSummaryPage("Summary");
            pageShoppingCartSummary.AssertSummaryTabOnShoppingCartSummaryPage("Product");
            pageShoppingCartSummary.AssertSummaryTabOnShoppingCartSummaryPage("Description");
            pageShoppingCartSummary.AssertSummaryTabOnShoppingCartSummaryPage("Avail.");
            pageShoppingCartSummary.AssertSummaryTabOnShoppingCartSummaryPage("Unit price");
            pageShoppingCartSummary.AssertSummaryTabOnShoppingCartSummaryPage("Qty");
            pageShoppingCartSummary.AssertSummaryTabOnShoppingCartSummaryPage("Total");
            pageShoppingCartSummary.AssertDeleteIcon();
            pageShoppingCartSummary.AssertOrderDeliveryOnShoppingCartSummaryPage("DELIVERY ADDRESS (HOUSE)");
            pageShoppingCartSummary.AssertOrderDeliveryOnShoppingCartSummaryPage("INVOICE ADDRESS (HOUSE)");
            pageShoppingCartSummary.AssertOrderDeliveryOnShoppingCartSummaryPage("Continue shopping");
            pageShoppingCartSummary.AssertOrderDeliveryOnShoppingCartSummaryPage("Proceed to checkout");

            return new ShoppingCartSummaryPage(webDriver);
            }
        }
    }
