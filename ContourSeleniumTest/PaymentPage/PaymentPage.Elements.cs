using OpenQA.Selenium;

namespace ContourSeleniumTest
    {
    internal partial class PaymentPage
        {
        IWebElement CartSummary => webDriver.FindElement(By.Id("cart_summary"));
        IWebElement PayByBankWireLink => webDriver.FindElement(By.XPath("//a[@title='Pay by bank wire']"));
        IWebElement IConfirmMyOrderBtn => webDriver.FindElement(By.XPath("//span[contains(text(),'I confirm my order')]"));
        IWebElement BankWirePaymentForm => webDriver.FindElement(By.XPath("//form[@method='post']"));
        IWebElement OrderConfirmationBox => webDriver.FindElement(By.XPath("//div[@class='box']"));
        }
    }
