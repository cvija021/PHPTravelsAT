using OpenQA.Selenium;

namespace PHPTravels.POM
{
    public class HomePage
    {
        #region Private Fields
        private IWebDriver driver;
        #endregion

        #region Constructor
        public HomePage(IWebDriver webDriver)
        {
            driver = webDriver;
        }
        #endregion

        #region Elements
        public IWebElement HotelsButton => driver.FindElement(By.ClassName("hotels"));
        public IWebElement MyAccountDropdown => driver.FindElement(By.Id("dropdownCurrency"));
        public IWebElement LoginButton => driver.FindElement(By.CssSelector("[href='https://www.phptravels.net/login']"));
        public IWebElement SignUpButton => driver.FindElement(By.CssSelector("[href='https://www.phptravels.net/register']"));
        #endregion

        #region Methods
        public void MuAccountClick() => MyAccountDropdown.Click();
        public void SelectLogin() => LoginButton.Click();
        public void SelectSignUp() => SignUpButton.Click();
        #endregion
    }
}
