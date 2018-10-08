using OpenQA.Selenium;

namespace weddingventure.com.Pages
{
    public class RegisterPage : PageBase
    {
        public RegisterPage(IWebDriver driver) : base(driver)
        {
        }
        
        public readonly string pageUrl = "https://vendors.weddingventure.com/Account/Register";
        public IWebElement ErrorMessage => Driver.FindElement(By.Id("termsAcceptanceError"));
        public IWebElement FirstNameField => Driver.FindElement(By.Id("FirstName"));
        public IWebElement EmailField => Driver.FindElement(By.Id("Email_Register"));
        public IWebElement PasswordField => Driver.FindElement(By.Id("Password_Register"));
        public IWebElement ConfirmPasswordField => Driver.FindElement(By.Id("ConfirmPassword"));

        public IWebElement AcceptTermCheckBox =>
            Driver.FindElement(By.XPath("/html/body/section/div/div/div/div/div[1]/form/label/input"));
        public IWebElement CreateAccountButton => Driver.FindElement(By.Id("registrationSubmit"));
        public IWebElement SignInButton => Driver.FindElement(By.XPath("/html/body/section/div/div/div/div/div[1]/form/div[7]/a"));
        public IWebElement ErrorMessageUserAlreadyExist =>
            Driver.FindElement(By.ClassName("validation-summary-errors text-danger"));


        public void GoToPage()
        {
            Driver.Navigate().GoToUrl(pageUrl);
        }

        public void FillTheFirstNameField()
        {
            FirstNameField.Clear();
            FirstNameField.SendKeys(Data.firstName);
        }

        public void FillTheEmailField()
        {
            EmailField.Clear();
            EmailField.SendKeys(Data.email);
        }

        public void FillThePasswordField()
        {
            PasswordField.Clear();
            PasswordField.SendKeys(Data.password);
        }

        public void FillTheConfirmPasswordField()
        {
            ConfirmPasswordField.Clear();
            ConfirmPasswordField.SendKeys(Data.password);
        }

        public CreateBusinessProfilePage CreateAccountButtonClick()
        {
            CreateAccountButton.Click();
            return new CreateBusinessProfilePage(Driver);
        }
    }
}
