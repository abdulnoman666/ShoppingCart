using OpenQA.Selenium;

namespace ContourSeleniumTest
    {
    internal partial class AuthenticationPage
        {
        IWebElement EmailAddressFld => webDriver.FindElement(By.Id("email"));
        IWebElement PasswordFld => webDriver.FindElement(By.Id("passwd"));
        IWebElement SignInBtn => webDriver.FindElement(By.Id("SubmitLogin"));
        }
    }
