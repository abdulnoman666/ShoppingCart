using System;
using System.IO;
using System.Reflection;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace ContourSeleniumTest
    {
    class HelperFunctions
        {
        private static IWebDriver webDriver;
        internal static AuthenticationPage LaunchWebPage (string Url)
            {
            webDriver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            webDriver.Navigate().GoToUrl(Url);
            Maximize();
            ImplicitWait(15);
            return new AuthenticationPage(webDriver);
            }

        internal static void Maximize ()
            {
            webDriver.Manage().Window.Maximize();
            }

        internal static void ImplicitWait (int n)
            {
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(n);
            }

        internal static string GetElementText (IWebElement element)
            {
            string value = element.Text;
            return value;
            }

        internal static string GetAttributeValue (string desc)
            {
            WaitForSeconds(3);
            IWebElement element  = webDriver.FindElement(By.XPath("//input[@value='"+ desc + "']"));
            string value = element.GetAttribute("value");
            return value;
            }

        internal static void CloseWebPage ()
            {
            webDriver.Quit();
            }

        internal static void EnterValue (IWebElement element, string value)
            {
            element.Clear();
            element.SendKeys(value);
            }

        internal static void ClickElement (IWebElement element)
            {
            element.Click();
            }

        internal static void ScrollElementToBecomeVisible (IWebElement element)
            {
            IJavaScriptExecutor jsExec = (IJavaScriptExecutor) webDriver;
            jsExec.ExecuteScript("arguments[0].scrollIntoView(true);", element);
            }

        internal static void TakeMouseOnItemOfChoice (string v)
            {
            Actions action = new Actions(webDriver);
            IWebElement element = webDriver.FindElement(By.XPath("//a[@title='" + v + "']"));
            action.MoveToElement(element).Perform();
            }

        internal static void WaitForSeconds (int n)
            {
            Thread.Sleep(n * 1000);
            }

        }
    }
