using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace PracticetestAutomation.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;
        private readonly By usernameField = By.Id("username");
        private readonly By passwordField = By.Id("password");
        private readonly By submitButton = By.Id("submit");
        private readonly By errorMessage = By.Id("error");

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public void EnterUsername(string username)
        {
            driver.FindElement(usernameField).SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            driver.FindElement(passwordField).SendKeys(password);
        }

        public void ClickSubmit()
        {
            driver.FindElement(submitButton).Click();
        }

        public string GetErrorMessage()
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(errorMessage)).Text;
        }

        public bool IsErrorMessageDisplayed()
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(errorMessage)).Displayed;
        }
    }
}
