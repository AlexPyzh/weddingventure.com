using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using weddingventure.com.Pages;

namespace weddingventure.com
{
    public class TestBase
    {
        protected static IWebDriver driver;
        protected const string pathToChromeDriver = @"c:\Install\Selenium\ChromeDriver\";
        protected MainPage MainPage;
        protected PageWithRegisterLink PageWithRegisterLink;
        protected RegisterPage RegisterPage;
        protected CreateBusinessProfilePage CreateBusinessProfilePage;


        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver(pathToChromeDriver);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            driver?.Close();
            driver?.Dispose();
        }
    }
}
