# MSTest Selenium Project

This project contains automated test cases using MSTest, Selenium, and the Page Object Model (POM) pattern. The tests are designed to run in parallel and use explicit waits for better reliability.

## Prerequisites

- Visual Studio 2022
- .NET SDK
- ChromeDriver (or any other WebDriver you prefer)
- NuGet packages:
  - Selenium.WebDriver
  - Selenium.Support
  - MSTest.TestFramework
  - MSTest.TestAdapter

## Setup

1. **Clone the repository**:
   ```sh
   git clone https://github.com/your-repo/mstest-selenium-project.git
   cd mstest-selenium-project
   ```

2. **Open the project in Visual Studio**.

3. **Restore NuGet packages**:
   ```sh
   dotnet restore
   ```

## Running Tests

### Build the Project

1. **Build the project** in Visual Studio:
   - Go to `Build` > `Build Solution` or press `Ctrl+Shift+B`.

### Run Tests

1. **Run tests in parallel**:
   - Open the `Test` menu in Visual Studio.
   - Select `Test Settings` > `Default Processor Architecture` > `x64` (or `x86` based on your setup).
   - Ensure parallel test execution is enabled in your `.runsettings` file:
     ```xml
     <RunSettings>
       <RunConfiguration>
         <MaxCpuCount>0</MaxCpuCount>
       </RunConfiguration>
     </RunSettings>
     ```

2. **Run the tests**:
   - Go to `Test` > `Run All Tests` or press `Ctrl+R, A`.

### Test Cases

#### Test Case 1: Positive Login Test

- **Description**: Verifies successful login with valid credentials.
- **Steps**:
  1. Open the login page.
  2. Enter username `student`.
  3. Enter password `Password123`.
  4. Click the Submit button.
  5. Verify the new page URL contains `practicetestautomation.com/logged-in-successfully/`.
  6. Verify the new page contains the text `Congratulations` or `successfully logged in`.
  7. Verify the Log out button is displayed.

#### Test Case 2: Negative Username Test

- **Description**: Verifies error message when logging in with an invalid username.
- **Steps**:
  1. Open the login page.
  2. Enter username `incorrectUser`.
  3. Enter password `Password123`.
  4. Click the Submit button.
  5. Verify the error message is displayed.
  6. Verify the error message text is `Your username is invalid!`.

#### Test Case 3: Negative Password Test

- **Description**: Verifies error message when logging in with an invalid password.
- **Steps**:
  1. Open the login page.
  2. Enter username `student`.
  3. Enter password `incorrectPassword`.
  4. Click the Submit button.
  5. Verify the error message is displayed.
  6. Verify the error message text is `Your password is invalid!`.

## Notes

- **Parallel Execution**: Ensure that your tests are designed to run independently to avoid conflicts when running in parallel.
- **Explicit Waits**: The tests use explicit waits to ensure elements are fully loaded before interactions, improving reliability.

## Troubleshooting

- If you encounter issues with WebDriver, ensure that the correct version of ChromeDriver is installed and matches your browser version.
- Check the test output in Visual Studio for detailed error messages and stack traces.

## Contributing

Feel free to open issues or submit pull requests for improvements and bug fixes.

## License

This project is licensed under the MIT License.
```

This `README.md` file provides clear instructions on how to set up, build, and run the test cases, along with notes on parallel execution and explicit waits. If you need further assistance, feel free to ask!