using OpenQA.Selenium;

namespace ContourSeleniumTest
    {
    internal partial class AddressesPage
        {
        private IWebDriver webDriver;

        public AddressesPage (IWebDriver webDriver)
            {
            this.webDriver = webDriver;
            }

        IWebElement DeliveryAddressDropdown => webDriver.FindElement(By.Id("uniform-id_address_delivery"));
        IWebElement UseDeliveryAddressAsBillingAddressCheckbox => webDriver.FindElement(By.Id("uniform-addressesAreEquals"));
        IWebElement OrderDelivery => webDriver.FindElement(By.Id("center_column"));
        IWebElement UpdateLink => webDriver.FindElement(By.LinkText("Update"));
        IWebElement CommentSection => webDriver.FindElement(By.XPath("//textarea[@class='form-control']"));
        IWebElement ProceedToCheckoutBtn => webDriver.FindElement(By.XPath("//button[@name='processAddress']"));
        IWebElement UpdateDeliveryAddressBtn => webDriver.FindElement(By.LinkText("Update"));
        IWebElement AddressFld => webDriver.FindElement(By.Id("address1"));
        IWebElement SaveButton => webDriver.FindElement(By.Id("submitAddress"));
        }
    }
