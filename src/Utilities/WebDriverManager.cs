using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumUITests.Utilities
{
    public static class WebDriverManager
    {
        public static IWebDriver Driver { get; private set; }

        public static IWebDriver InitializeDriver()
        {
            Driver = new ChromeDriver();
            return Driver;
        }

        public static void QuitDriver()
        {
            Driver.Quit();
            Driver = null;
        }
    }
}