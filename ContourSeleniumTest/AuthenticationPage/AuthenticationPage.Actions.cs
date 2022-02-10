using OpenQA.Selenium;

namespace ContourSeleniumTest
    {
    internal partial class AuthenticationPage
        {
        private IWebDriver webDriver;

        internal AuthenticationPage (IWebDriver webDriver)
            {
            this.webDriver = webDriver;
            }

        internal AuthenticationPage EnterEmailAddressOnAuthenticationPage (string email)
            {
            HelperFunctions.EnterValue(EmailAddressFld, email);
            return new AuthenticationPage(webDriver);
            }

        internal AuthenticationPage EnterPasswordOnAuthenticationPage (string password)
            {
            HelperFunctions.EnterValue(PasswordFld, password);
            return new AuthenticationPage(webDriver);
            }

        internal MyAccountPage ClickSignInButtonOnAuthenticationPage ()
            {
            HelperFunctions.ClickElement(SignInBtn);
            return new MyAccountPage(webDriver);
            }
        }
    }
