using OpenQA.Selenium;

namespace weddingventure.com.Pages
{
    public class RegisterPage : PageBase
    {
        public RegisterPage(IWebDriver driver) : base(driver)
        {
        }

        private readonly string _pageUrl = "https://vendors.weddingventure.com/account/register";
        public IWebElement ErrorMessage => Driver.FindElement(By.Id("termsAcceptanceError"));
        public IWebElement FirstNameField => Driver.FindElement(By.Id("FirstName"));
        public IWebElement EmailField => Driver.FindElement(By.Id("Email_Register"));
        public IWebElement PasswordField => Driver.FindElement(By.Id("Password_Register"));
        public IWebElement ConfirmPasswordField => Driver.FindElement(By.Id("ConfirmPassword"));

        public IWebElement AcceptTermCheckBox =>
            Driver.FindElement(By.XPath("/html/body/section/div/div/div/div/div[1]/form/label/input"));
        public IWebElement CreateAccountButton => Driver.FindElement(By.Id("registrationSubmit"));
        public IWebElement signInButton => Driver.FindElement(By.XPath("/html/body/section/div/div/div/div/div[1]/form/div[7]/a"));
        public readonly string firstName = "Huan";
        public readonly string email = "huanweddingventure@mail.com";
        public readonly string password = "password";

        public  void GoToPage()
        {
            Driver.Navigate().GoToUrl(_pageUrl);
        }

        public void FillTheFirstNameField()
        {
            FirstNameField.Clear();
            FirstNameField.SendKeys(firstName);
        }

        public void FillTheEmailField()
        {
            EmailField.Clear();
            EmailField.SendKeys(email);
        }

        public void FillThePasswordField()
        {
            PasswordField.Clear();
            PasswordField.SendKeys(password);
        }

        public void FillTheConfirmPasswordField()
        {
            ConfirmPasswordField.Clear();
            ConfirmPasswordField.SendKeys(password);
        }

        public CreateBusinessProfilePage CreateAccountButtonClick()
        {
            CreateAccountButton.Click();
            return new CreateBusinessProfilePage(Driver);
        }
    }
}
