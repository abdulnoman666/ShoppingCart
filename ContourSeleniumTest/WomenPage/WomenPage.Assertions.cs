using NUnit.Framework;

namespace ContourSeleniumTest
    {
    internal partial class WomenPage
        {
        internal WomenPage AssertProductAddedShoppingCartOnWomenPage (string Expected)
            {
            HelperFunctions.WaitForSeconds(3);
            string Actual = HelperFunctions.GetElementText(PopupPage);
            Assert.IsTrue(Actual.Contains(Expected));
            return new WomenPage(webDriver);
            }
        }
    }
