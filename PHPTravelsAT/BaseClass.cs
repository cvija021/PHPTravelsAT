using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;
using System.Threading;

namespace PHPTravels
{
    [TestFixture]
    public class BaseClass
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;

        private string driverPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private static readonly int timeoutInSeconds = 15;

        //public static IWebDriver driver = new ChromeDriver(driverPath);
        //public static WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));

        [SetUp]
        public virtual void Setup()
        {
            // Driver
            driver = new ChromeDriver(/*driverPath*/);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
        }

        [TearDown]
        public virtual void Dispose()
        {
            Thread.Sleep(2000);
            if (driver != null)
            {
                driver.Quit();
            }
        }
    }
}
