using NUnit.Framework;
using OpenQA.Selenium;
using PHPTravels;
using PHPTravels.POM;
using SeleniumExtras.WaitHelpers;

namespace PHPTravelsAT
{
    public class Tests : BaseClass

    {
        #region Private Fields
        //private HomePage homepage;
        #endregion

        [SetUp]
        override public void Setup()
        {
            base.Setup();
            HomePage homepage = new HomePage(driver);
            driver.Navigate().GoToUrl("https://www.phptravels.net/");
        }

        [Test]
        public void LoginPositive()
        {
            
            wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("header-logo")));
            // Test line
            Assert.Pass();
        }

        [Test]
        public void LoginNegative()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("header-logo")));
            Assert.Pass();
        }
    }
}