namespace SeleniumUITests.Utilities
{
    public static class TestData
    {
        public static class Urls
        {
            public const string RegistrationFormFirstStep = "https://devtest.giganciprogramowania.edu.pl/zapisz-sie";
        }

        public static class FormData
        {
            public const string GuardianName = "Artur";
            public const string Email = "karolgiganci+fakedata80696@gmail.com";
            public const string ContactNumber = "123456651";
            public const string BirthYear = "2005";
            public const string StudentFirstName = "Maciej";
            public const string StudentLastName = "Testowy";
            public const string GuardianLastName = "Testowy";
            public const string PostalCode = "26-900";
            public const string IncorrectEmail = "user#example.com";
            public const string IncorrectPhoneNumber = "12345665";
        }

        public static class ValidationMessages
        {
            public const string RequiredFields = "Prosimy uzupełnić wszystkie wymagane pola.";
            public const string InvalidEmail = "Nieprawidłowy adres e-mail";
            public const string InvalidPhoneNumber = "Niepoprawny numer telefonu";
        }

        public static class Headers
        {
            public const string RegistrationPage = "Wypełnij dane"; 
            public const string RegistrationSecondStep = "Wybierz tematykę kursu"; 
        }
    }
}