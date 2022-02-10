using NUnit.Framework;

namespace ContourSeleniumTest
    {
    [TestFixture]
    public class TestCases
        {
        [Test]
        public void TestCase1 ()
            {
            HelperFunctions.LaunchWebPage("http://automationpractice.com/index.php?controller=my-account")
                .EnterEmailAddressOnAuthenticationPage("noman.software@yahoo.com")
                .EnterPasswordOnAuthenticationPage("pakistan")
                .ClickSignInButtonOnAuthenticationPage()
                .ClickCartDropdownOnMyAccountPage("Your shopping cart is empty.")
                .ClickWomenLinkOnShoppingSummaryPage()
                .TakeMouseOnItemOfChoiceOnWomenPage("Faded Short Sleeve T-shirts")
                .ClickAddToCartButtonOnWomenPage()
                .AssertProductAddedShoppingCartOnWomenPage("There is 1 item in your cart.")
                .AssertProductAddedShoppingCartOnWomenPage("Orange, S")
                .AssertProductAddedShoppingCartOnWomenPage("1")
                .AssertProductAddedShoppingCartOnWomenPage("$16.51")
                .AssertProductAddedShoppingCartOnWomenPage("$16.51")
                .AssertProductAddedShoppingCartOnWomenPage("$2.00")
                .AssertProductAddedShoppingCartOnWomenPage("$18.51")
                .ClickProceedToCheckoutButtonOnWomenPage()
                .ClickProceedToCheckoutButtonOnShoppingSummaryPage()
                .AssertDeliveryAddressOnAddressesPage("house")
                .AssertUseDeliveryAddressAsBillingAddressCheckboxSelectedOnAddressesPage()
                .AssertAddressesOnAddressesPage("House P-1105 Asghar Mall Road")
                .EnterCommentsOnAddressesPage("Handle Carefully")
                .ClickProceedToCheckoutButtonOnAddressesPage()
                .AssertShippingOptionDisplayedOnShippingPage("My carrier Delivery next day!")
                .AssertShippingOptionDisplayedOnShippingPage("$2.00")
                .ClickTermsOfServiceCheckboxOnShippingPage()
                .ClickProceedToCheckoutButtonOnAddressesPage()
                .AssertPaymentTabOnPaymentPage("Faded Short Sleeve T-shirts")
                .AssertPaymentTabOnPaymentPage("In stock")
                .AssertPaymentTabOnPaymentPage("$16.51")
                .AssertPaymentTabOnPaymentPage("1")
                .AssertPaymentTabOnPaymentPage("$2.00")
                .AssertPaymentTabOnPaymentPage("$18.51")
                .ClickPayByBankWireLinkOnPaymentPage()
                .AssertDescriptionOnBankWirePaymentPage("The total amount of your order comes to: $18.51 (tax incl.)")
                .AssertDescriptionOnBankWirePaymentPage("We allow the following currency to be sent via bank wire: Dollar")
                .AssertDescriptionOnBankWirePaymentPage("Bank wire account information will be displayed on the next page.")
                .AssertDescriptionOnBankWirePaymentPage("Please confirm your order by clicking \"I confirm my order.\".")
                .ClickIConfirmMyOrderButtonOnPaymentPage()
                .AssertOrderConfirmationOnPaymentPage("Amount $18.51")
                .AssertOrderConfirmationOnPaymentPage("Name of account owner Pradeep Macharla")
                .AssertOrderConfirmationOnPaymentPage("Include these details xyz")
                .AssertOrderConfirmationOnPaymentPage("Bank name RTP")
                //.AssertOrderConfirmationOnPaymentPage("Do not forget to insert your order reference KPQHNVIMM in the subject of your bank wire") I am unable to find out how it is calculating order reference number
                .AssertOrderConfirmationOnPaymentPage("Your order will be sent as soon as we receive payment")
                .AssertOrderConfirmationOnPaymentPage("If you have questions, comments or concerns, please contact our expert customer support team");
            //I am not getting any emails in my email address so I cannot verify it
            }

        [Test]
        public void TestCase2 ()
            {
            HelperFunctions.LaunchWebPage("http://automationpractice.com/index.php?controller=my-account")
                .EnterEmailAddressOnAuthenticationPage("noman.software@yahoo.com")
                .EnterPasswordOnAuthenticationPage("pakistan")
                .ClickSignInButtonOnAuthenticationPage()
                .ClickCartDropdownOnMyAccountPage("Your shopping cart is empty.")
                .ClickWomenLinkOnShoppingSummaryPage()
                .TakeMouseOnItemOfChoiceOnWomenPage("Faded Short Sleeve T-shirts")
                .ClickAddToCartButtonOnWomenPage()
                .AssertProductAddedShoppingCartOnWomenPage("There is 1 item in your cart.")
                .AssertProductAddedShoppingCartOnWomenPage("Orange, S")
                .AssertProductAddedShoppingCartOnWomenPage("1")
                .AssertProductAddedShoppingCartOnWomenPage("$16.51")
                .AssertProductAddedShoppingCartOnWomenPage("$16.51")
                .AssertProductAddedShoppingCartOnWomenPage("$2.00")
                .AssertProductAddedShoppingCartOnWomenPage("$18.51")
                .ClickProceedToCheckoutButtonOnWomenPage()
                .ClickPlusButtonOnShoppingCartSummaryPage()
                .AssertQuantityOnShoppingCartSummaryPage("2")
                .ClickProceedToCheckoutButtonOnShoppingSummaryPage()
                .AssertDeliveryAddressOnAddressesPage("house")
                .AssertUseDeliveryAddressAsBillingAddressCheckboxSelectedOnAddressesPage()
                .AssertAddressesOnAddressesPage("House P-1105 Asghar Mall Road")
                .EnterCommentsOnAddressesPage("Handle Carefully")
                .ClickUpdateButtonBillingAddress()
                .EnterBillingAddress("Islamabad F5/1")
                .ClickSaveButtonOnAddressPage()
                .ClickProceedToCheckoutButtonOnAddressesPage()
                .AssertShippingOptionDisplayedOnShippingPage("My carrier Delivery next day!")
                .AssertShippingOptionDisplayedOnShippingPage("$2.00")
                .ClickProceedToCheckoutButtonOnAddressesPage(false)
                .AssertErrorMessageDisplayedOnShippingPage("You must agree to the terms of service before continuing.")
                .ClickCloseButtonOnErrorMessage()
                .ClickTermsOfServiceCheckboxOnShippingPage()
                .ClickProceedToCheckoutButtonOnAddressesPage()
                .AssertPaymentTabOnPaymentPage("Faded Short Sleeve T-shirts")
                .AssertPaymentTabOnPaymentPage("In stock")
                .AssertPaymentTabOnPaymentPage("$16.51")
                .AssertPaymentTabOnPaymentPage("2")
                .AssertPaymentTabOnPaymentPage("$2.00")
                .AssertPaymentTabOnPaymentPage("$33.02")
                .AssertPaymentTabOnPaymentPage("$35.02")
                .ClickPayByBankWireLinkOnPaymentPage()
                .AssertDescriptionOnBankWirePaymentPage("The total amount of your order comes to: $35.02 (tax incl.)")
                .AssertDescriptionOnBankWirePaymentPage("We allow the following currency to be sent via bank wire: Dollar")
                .AssertDescriptionOnBankWirePaymentPage("Bank wire account information will be displayed on the next page.")
                .AssertDescriptionOnBankWirePaymentPage("Please confirm your order by clicking \"I confirm my order.\".")
                .ClickIConfirmMyOrderButtonOnPaymentPage()
                .AssertOrderConfirmationOnPaymentPage("Amount $35.02")
                .AssertOrderConfirmationOnPaymentPage("Name of account owner Pradeep Macharla")
                .AssertOrderConfirmationOnPaymentPage("Include these details xyz")
                .AssertOrderConfirmationOnPaymentPage("Bank name RTP")
                //.AssertOrderConfirmationOnPaymentPage("Do not forget to insert your order reference KPQHNVIMM in the subject of your bank wire") I am unable to find out how it is calculating order reference number
                .AssertOrderConfirmationOnPaymentPage("Your order will be sent as soon as we receive payment")
                .AssertOrderConfirmationOnPaymentPage("If you have questions, comments or concerns, please contact our expert customer support team");

            //I am unable to find customer service department link in Your Check Must Include Section
            }

        [TearDown]
        public void Close ()
            {
            HelperFunctions.CloseWebPage();
            }
        }
    }
