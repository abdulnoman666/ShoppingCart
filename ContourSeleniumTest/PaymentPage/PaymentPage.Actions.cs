namespace ContourSeleniumTest
    {
    internal partial class PaymentPage
        {
        internal PaymentPage ClickPayByBankWireLinkOnPaymentPage ()
            {
            HelperFunctions.ClickElement(PayByBankWireLink);
            return new PaymentPage(webDriver);
            }

        internal PaymentPage ClickIConfirmMyOrderButtonOnPaymentPage ()
            {
            HelperFunctions.ClickElement(IConfirmMyOrderBtn);
            return new PaymentPage(webDriver);
            }
        }
    }
