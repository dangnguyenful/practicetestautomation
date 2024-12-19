using OpenQA.Selenium;
using PracticetestAutomation.Pages;
using PracticetestAutomation.Utilities;

namespace PracticetestAutomation.Testcases
{
    [TestClass]
    public class PositiveLoginTest
    {
        private IWebDriver? driver;
        private LoginPage? loginPage;
        private HomePage? homePage;

        [TestInitialize]
        public void SetUp()
        {
            driver = TestUtilities.InitializeDriver();
            loginPage = new LoginPage(driver);
            homePage = new HomePage(driver);
        }

        [TestMethod]
        public void TestPositiveLogin()
        {
            // Open page
            driver?.Navigate().GoToUrl("https://practicetestautomation.com/practice-test-login/");

            // Type username
            loginPage?.EnterUsername("student");

            // Type password
            loginPage?.EnterPassword("Password123");

            // Push Submit button
            loginPage?.ClickSubmit();

            // Verify new page URL
            Assert.IsTrue(driver?.Url.Contains("practicetestautomation.com/logged-in-successfully/"));

            // Verify new page contains expected text
            Assert.IsTrue(homePage?.IsSuccessMessageDisplayed());

            // Verify button Log out is displayed
            Assert.IsTrue(homePage?.IsLogoutButtonDisplayed());
        }

        [TestCleanup]
        public void TearDown()
        {
            TestUtilities.TearDownDriver(driver);
        }
    }
}
