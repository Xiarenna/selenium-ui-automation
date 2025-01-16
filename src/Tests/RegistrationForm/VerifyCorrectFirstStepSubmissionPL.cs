using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumUITests.Pages;
using SeleniumUITests.Utilities;

namespace SeleniumUITests.Tests
{
    public class VerifyCorrectFirstStepSubmissionPL
    {
        private IWebDriver driver;
        private RegistrationPageFirstStep registrationPageFirstStep;

        [SetUp]
        public void BeforeTest()
        {
            driver = WebDriverManager.InitializeDriver();
            registrationPageFirstStep = new RegistrationPageFirstStep(driver);

            registrationPageFirstStep.NavigateTo(TestData.Urls.RegistrationFormFirstStep);
            registrationPageFirstStep.VerifyHeaderIsCorrect();
        }

        // Test Case ID: TC-04
        [Test]
        public void VerifyCorrectFirstStepSubmission()
        {
            // Fill the form with correct data
            registrationPageFirstStep.FillFormWithCorrectData();

            // Submit the form
            registrationPageFirstStep.SubmitForm();

            // Verify successful first step submission
            registrationPageFirstStep.VerifyCorrectFirstStepSubmission();
        }

        [TearDown]
        public void AfterTest()
        {
            WebDriverManager.QuitDriver();
        }
    }
}