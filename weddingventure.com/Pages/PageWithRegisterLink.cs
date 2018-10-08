using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using weddingventure.com.Pages;

namespace weddingventure.com
{
    public class PageWithRegisterLink : PageBase
    {
        public PageWithRegisterLink(IWebDriver driver) : base(driver){}

        private const string pageUrl = "https://vendors.weddingventure.com/";

        public IWebElement RegisterLink => Driver.FindElement(By.XPath("/html/body/header/div[1]/div/div/div/ul/li[1]/a"));
        public IWebElement LoginLink => Driver.FindElement(By.LinkText("Login"));

        public void GoToPage()
        {
            Driver.Navigate().GoToUrl(pageUrl);
        }

        public RegisterPage GoToRegisterPage()
        {
            RegisterLink.Click();
            return new RegisterPage(Driver);
        }

        public SignInPage LoginLinkClick()
        {
            LoginLink.Click();
            return new SignInPage(Driver);
        }

    }
}
