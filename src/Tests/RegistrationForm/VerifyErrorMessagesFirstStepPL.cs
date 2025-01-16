using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumUITests.Pages;
using SeleniumUITests.Utilities;
using static SeleniumUITests.Utilities.TestData;

namespace SeleniumUITests.Tests
{
    public class VerifyErrorMessagesFirstStepPL
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

        // Test Case ID: TC-02
        [Test]
        public void VerifyIncorrectEmailFormat()
        {
            // Fill "Adres e-mail" input with incorrect email format
            registrationPage.FillEmail(FormData.IncorrectEmail);

            // Submit the form
            registrationPage.SubmitForm();

            // Verify validation message for incorrect email format
            registrationPage.VerifyIncorrectEmailFormat();
        }

        // Test Case ID: TC-03
        [Test]
        public void VerifyIncorrectPhoneNumberFormat()
        {
            // Fill "Phone number" input with incorrect phone number format
            registrationPage.FillPhoneNumber(FormData.IncorrectPhoneNumber);

            // Submit the form
            registrationPage.SubmitForm();

            // Verify validation message for incorrect phone number format
            registrationPage.VerifyIncorrectPhoneNumberFormat();
        }

        [TearDown]
        public void AfterTest()
        {
            registrationPage.VerifyHeaderIsCorrect();
            WebDriverManager.QuitDriver();
        }
    }
}