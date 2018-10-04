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

        protected const string pageUrl = "https://vendors.weddingventure.com/";

        public IWebElement registerLink => Driver.FindElement(By.XPath("/html/body/header/div[1]/div/div/div/ul/li[1]/a"));

        public RegisterPage GoToRegisterPage()
        {
            registerLink.Click();

            return new RegisterPage(Driver);
        }

    }
}
