using OpenQA.Selenium;
using PracticetestAutomation.Pages;
using PracticetestAutomation.Utilities;

namespace PracticetestAutomation.Testcases
{

    [TestClass]
    public class NegativeUsernameTest
    {
        private IWebDriver? driver;
        private LoginPage? loginPage;

        [TestInitialize]
        public void SetUp()
        {
            driver = TestUtilities.InitializeDriver();
            loginPage = new LoginPage(driver);
        }

        [TestMethod]
        public void TestNegativeUsername()
        {
            // Open page
            driver?.Navigate().GoToUrl("https://practicetestautomation.com/practice-test-login/");

            // Type username
            loginPage?.EnterUsername("incorrectUser");

            // Type password
            loginPage?.EnterPassword("Password123");

            // Push Submit button
            loginPage?.ClickSubmit();

            // Verify error message is displayed
            Assert.IsTrue(loginPage?.IsErrorMessageDisplayed());

            // Verify error message text
            Assert.AreEqual("Your username is invalid!", loginPage?.GetErrorMessage());
        }

        [TestCleanup]
        public void TearDown()
        {
            TestUtilities.TearDownDriver(driver);
        }
    }
}
