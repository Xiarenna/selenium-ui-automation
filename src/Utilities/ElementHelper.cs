using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumUITests.Utilities
{
    public static class ElementHelper
    {
        private static IWebDriver driver => WebDriverManager.Driver;

        public static bool IsElementVisible(By locator, int timeoutInSeconds = 10)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
                return true;
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
        }

        public static string GetUrl()
        {
            return driver.Url;
        }

        public static IWebElement FindElement(By locator, int timeoutInSeconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
        }

        public static void SendKeys(By locator, string text, int timeoutInSeconds = 10)
        {
            IWebElement element = FindElement(locator, timeoutInSeconds);
            element.Clear();
            element.SendKeys(text);
        }

        public static void Click(By locator, int timeoutInSeconds = 10)
        {
            IWebElement element = FindElement(locator, timeoutInSeconds);
            element.Click();
        }

        public static void AssertIsTrue(bool condition, string message = "")
        {
            NUnit.Framework.Assert.IsTrue(condition, message);
        }

        public static void AssertAreEqual(string expected, string actual, string message = "")
        {
            NUnit.Framework.Assert.AreEqual(expected, actual, message);
        }
    }
}