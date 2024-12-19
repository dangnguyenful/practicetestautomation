using OpenQA.Selenium;
using PracticetestAutomation.Pages;
using PracticetestAutomation.Utilities;

namespace PracticetestAutomation.Testcases
{
    [TestClass]
    public class NegativePasswordTest
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
        public void TestNegativePassword()
        {
            // Open page
            driver?.Navigate().GoToUrl("https://practicetestautomation.com/practice-test-login/");

            // Type username
            loginPage?.EnterUsername("student");

            // Type password
            loginPage?.EnterPassword("incorrectPassword");

            // Push Submit button
            loginPage?.ClickSubmit();

            // Verify error message is displayed
            Assert.IsTrue(loginPage?.IsErrorMessageDisplayed());

            // Verify error message text
            Assert.AreEqual("Your password is invalid!", loginPage?.GetErrorMessage());
        }

        [TestCleanup]
        public void TearDown()
        {
            TestUtilities.TearDownDriver(driver);
        }
    }
}
