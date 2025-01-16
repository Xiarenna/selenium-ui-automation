using System;
using System.Collections;
using OpenQA.Selenium;
using SeleniumUITests.Utilities;
using static SeleniumUITests.Utilities.ElementHelper;
using static SeleniumUITests.Utilities.TestData;

namespace SeleniumUITests.Pages
{
    public class RegistrationPageFirstStep
    {
        private readonly IWebDriver driver;
        private readonly string RegistrationFormUrl = Urls.RegistrationFormFirstStep;

        // Element locators

        private readonly By headerFirstStep = By.ClassName("h3");
        private readonly By headerSecondStep = By.ClassName("h4");
        private readonly By guardianNameInput = By.CssSelector("input.form-control[name='parentName']");
        private readonly By emailInput = By.CssSelector("input.form-control[name='email']");
        private readonly By phonetNumberInput = By.CssSelector("input.form-control[name='phoneNumber']");
        private readonly By birthYearInput = By.CssSelector("input.form-control[name='birthYear']");
        private readonly By acceptTermsCheckbox = By.Id("statuteAgreed"); 
        private readonly By acceptMarketingCheckbox = By.Id("advertisementAgreed"); 
        private readonly By submitButton = By.Id("agreement-step-submit");
        private readonly By alertMessageGuardianName = By.CssSelector("input.form-control[name=\"parentName\"] ~ .formValidation");
        private readonly By alertMessageEmail = By.CssSelector("input.form-control[name=\"email\"] ~ .formValidation");
        private readonly By alertMessagePhoneNumber = By.CssSelector("input.form-control[name=\"phoneNumber\"] ~ .formValidation");
        private readonly By alertMessageBirthYear = By.CssSelector("input.form-control[name=\"birthYear\"] ~ .formValidation");
        private readonly By alertMessageTerms = By.CssSelector("#statuteAgreed ~ .formValidation");
        private readonly By alertMessageMarketing = By.CssSelector("#advertisementAgreed ~ .formValidation");

        public RegistrationPageFirstStep(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void NavigateTo(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void VerifyHeaderIsCorrect()
        {
            string headerText = FindElement(this.headerFirstStep).Text;
            AssertAreEqual(TestData.Headers.RegistrationPage, headerText, "Header name is not correct!");
        }

        public void SubmitForm()
        {
            Click(submitButton);
        }

        public bool IsValidationMessageDisplayed(By locator)
        {
            return FindElement(locator).Displayed;
        }

        public string GetAlertText(By alertMessageLocator)
        {
            return FindElement(alertMessageLocator).Text;
        }

        public void verifyErrorMessageEmptyField(string fieldName)
        {
            switch(fieldName)
            {
                case "parentName":
                    AssertIsTrue(IsValidationMessageDisplayed(alertMessageGuardianName));
                    AssertAreEqual(ValidationMessages.RequiredFields, GetAlertText(alertMessageGuardianName));
                    break;
                case "email":
                    AssertIsTrue(IsValidationMessageDisplayed(alertMessageEmail));
                    AssertAreEqual(ValidationMessages.RequiredFields, GetAlertText(alertMessageEmail));
                    break;
                case "phoneNumber":
                    AssertIsTrue(IsValidationMessageDisplayed(alertMessagePhoneNumber));
                    AssertAreEqual(ValidationMessages.RequiredFields, GetAlertText(alertMessagePhoneNumber));
                    break;
                case "birthYear":
                    AssertIsTrue(IsValidationMessageDisplayed(alertMessageBirthYear));
                    AssertAreEqual(ValidationMessages.RequiredFields, GetAlertText(alertMessageBirthYear));
                    break;
                case "terms":
                    AssertIsTrue(IsValidationMessageDisplayed(alertMessageTerms));
                    AssertAreEqual(ValidationMessages.RequiredFields, GetAlertText(alertMessageTerms));
                    break;
                case "marketing":
                    AssertIsTrue(IsValidationMessageDisplayed(alertMessageMarketing));
                    AssertAreEqual(ValidationMessages.RequiredFields, GetAlertText(alertMessageMarketing));
                    break;
                default:
                    throw new ArgumentException("Invalid field name");
            }
        }

        public void VerifyIncorrectEmailFormat()
        {
            AssertIsTrue(IsValidationMessageDisplayed(alertMessageEmail));
            AssertAreEqual(ValidationMessages.InvalidEmail, FindElement(alertMessageEmail).Text, "Email validation message is not correct!");
        }

        public void VerifyIncorrectPhoneNumberFormat()
        {
            AssertIsTrue(IsValidationMessageDisplayed(alertMessagePhoneNumber));
            AssertAreEqual(ValidationMessages.InvalidPhoneNumber, FindElement(alertMessagePhoneNumber).Text, "Phone number validation message is not correct!");
        }

        public void FillFormWithCorrectData(){
            SendKeys(guardianNameInput, TestData.FormData.GuardianName);
            SendKeys(emailInput, TestData.FormData.Email);
            SendKeys(phonetNumberInput, TestData.FormData.ContactNumber);
            SendKeys(birthYearInput, TestData.FormData.BirthYear);
            Click(acceptTermsCheckbox);
            Click(acceptMarketingCheckbox);
        }

        public void VerifyCorrectFirstStepSubmission()
        {string headerText = FindElement(this.headerSecondStep).Text;
            AssertAreEqual(TestData.Headers.RegistrationSecondStep, headerText, "Header name is not correct!");}
    }
}