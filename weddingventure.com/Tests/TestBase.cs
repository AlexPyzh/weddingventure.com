using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using weddingventure.com.Data;
using weddingventure.com.Pages;

namespace weddingventure.com
{
    public class TestBase
    {
        protected IWebDriver driver;
        protected const string pathToChromeDriver = @"c:\Install\Selenium\ChromeDriver\";
        protected MainPage MainPage;
        protected PageWithRegisterLink PageWithRegisterLink;
        protected RegisterPage RegisterPage;
        protected CreateBusinessProfilePage CreateBusinessProfilePage;
        protected SignInPage SignInPage;
        protected DataSource Data = new DataSource();

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
