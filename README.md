# Selenium UI Automation Project

This project is an end-to-end UI automation framework using Selenium and C#. It is designed to automate interactions with a specified website, providing a structured approach to testing web applications.

## Project Structure

```
selenium-ui-automation
├── src
│   ├── Pages
│   │   └── HomePage.cs
│   ├── Tests
│   │   └── HomePageTests.cs
│   └── Utilities
│       └── WebDriverManager.cs
├── selenium-ui-automation.sln
├── selenium-ui-automation.csproj
└── README.md
```

## Setup Instructions

1. **Clone the Repository**
   Clone this repository to your local machine using:
   ```
   git clone <repository-url>
   ```

2. **Open the Project**
   Open the solution file `selenium-ui-automation.sln` in your preferred C# IDE.

3. **Install Dependencies**
   Ensure you have the necessary dependencies installed. You can use NuGet to install Selenium WebDriver and any testing framework (e.g., NUnit):
   ```
   Install-Package Selenium.WebDriver
   Install-Package NUnit
   ```

4. **Configure WebDriver**
   Modify the `WebDriverManager.cs` file to set up the WebDriver according to your browser preferences.

## Usage Guidelines

- **Running Tests**
  To run the tests, use the test runner integrated into your IDE or execute the tests via the command line using:
  ```
  dotnet test
  ```

- **Adding New Tests**
  To add new tests, create a new test class in the `Tests` directory and follow the structure of existing tests.

- **Extending Page Objects**
  To add new page objects, create a new class in the `Pages` directory and implement methods for interacting with the new page.
