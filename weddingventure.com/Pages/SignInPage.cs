using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace weddingventure.com.Pages
{
    public class SignInPage : PageBase
    {
        public SignInPage(IWebDriver driver) : base(driver)
        {

        }

        public IWebElement EmailField => Driver.FindElement(By.Id("Email_Login"));
        public IWebElement PasswordField => Driver.FindElement(By.Id("Password_Login"));
        public IWebElement EnterButton => Driver.FindElement(By.XPath("/html/body/section/div/div/div/div/div[1]/form/div[4]/input"));
    }
}
