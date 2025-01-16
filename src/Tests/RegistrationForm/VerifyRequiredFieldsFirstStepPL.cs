using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumUITests.Pages;
using SeleniumUITests.Utilities;

namespace SeleniumUITests.Tests
{
    public class VerifyRequiredFieldsFirstStepPL
    {
        private IWebDriver driver;
        private RegistrationPage registrationPage;

        [SetUp]
        public void BeforeTest()
        {
            driver = WebDriverManager.InitializeDriver();
            registrationPage = new RegistrationPage(driver);
            registrationPage.NavigateTo(TestData.Urls.RegistrationForm);
            registrationPage.VerifyHeaderIsCorrect();
        }

        // Test Case ID: TC-01
        [Test]
        public void VerifyRequiredFields()
        {
            // Submit the form without filling required fields
            registrationPage.SubmitForm();

            // Verify required fields validation
            registrationPage.verifyErrorMessageEmptyField("parentName");
            registrationPage.verifyErrorMessageEmptyField("email");
            registrationPage.verifyErrorMessageEmptyField("phoneNumber");
            registrationPage.verifyErrorMessageEmptyField("birthYear");
            registrationPage.verifyErrorMessageEmptyField("terms");
            registrationPage.verifyErrorMessageEmptyField("marketing");
        }

        [TearDown]
        public void AfterTest()
        {
            registrationPage.VerifyHeaderIsCorrect();
            WebDriverManager.QuitDriver();
        }
    }
}