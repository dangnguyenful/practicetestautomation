using OpenQA.Selenium;

namespace PracticetestAutomation.Pages
{
    public class HomePage
    {
        private readonly IWebDriver driver;
        private readonly By logoutButton = By.XPath("//a[text()='Log out']");

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public bool IsLogoutButtonDisplayed()
        {
            return driver.FindElement(logoutButton).Displayed;
        }

        public bool IsSuccessMessageDisplayed()
        {
            var bodyText = driver.FindElement(By.TagName("body")).Text;
            return bodyText.Contains("Congratulations") || bodyText.Contains("successfully logged in");
        }
    }
}
