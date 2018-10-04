using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace weddingventure.com
{
    [TestFixture]
    public class MainPage : PageBase
    {
        public MainPage(IWebDriver driver) : base(driver)
        {
            driver.Navigate().GoToUrl(_pageUrl);
        }

        private const string _pageUrl = "http://weddingventure.com/";
        public IWebElement freeVendorAccountLink => Driver.FindElement(By.XPath("/html/body/header/div[1]/div/ul/li[2]/a"));
        
        public override void GoToPage()
        {
            Driver.Navigate().GoToUrl(_pageUrl);
        }

        public PageWithRegisterLink GoToPageWithRegisterLink()
        {
            var windowHandles = Driver.WindowHandles;
            freeVendorAccountLink.Click();
            var newWindowHandles = Driver.WindowHandles;
            var openedWindowHandle = newWindowHandles.Except(windowHandles).Single();
            Driver.SwitchTo().Window(openedWindowHandle);

            return new PageWithRegisterLink(Driver);
        }

    }
}
