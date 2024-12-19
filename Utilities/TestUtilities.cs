using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PracticetestAutomation.Utilities
{
    public static class TestUtilities
    {
        public static IWebDriver InitializeDriver()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            return driver;
        }

        public static void TearDownDriver(IWebDriver? driver)
        {
            driver?.Quit();
        }
    }
}
