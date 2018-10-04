using NUnit.Framework;
using weddingventure.com.Pages;

namespace weddingventure.com.Tests
{
    class TestFixture : TestBase
    {
        [Test]
        public void RegisterNewPhotographer_EmptyFields_Negative()
        {
            MainPage = new MainPage(driver);
            PageWithRegisterLink = MainPage.GoToPageWithRegisterLink();
            RegisterPage = PageWithRegisterLink.GoToRegisterPage();
            RegisterPage.CreateAccountButton.Click();

            Assert.True(RegisterPage.ErrorMessage.Displayed);
        }

        [Test]
        public void RegisterNewPhotographer_OneEmptyField_Negative()
        {
            MainPage = new MainPage(driver);
            PageWithRegisterLink = MainPage.GoToPageWithRegisterLink();
            RegisterPage = PageWithRegisterLink.GoToRegisterPage();

            RegisterPage.FillTheFirstNameField();
            RegisterPage.FillTheEmailField();
            RegisterPage.FillThePasswordField();
            RegisterPage.ConfirmPasswordField.Clear();
            RegisterPage.CreateAccountButton.Click();
            Assert.True(RegisterPage.ErrorMessage.Displayed);

            RegisterPage.FirstNameField.Clear();
            RegisterPage.FillTheEmailField();
            RegisterPage.FillThePasswordField();
            RegisterPage.FillTheConfirmPasswordField();
            RegisterPage.CreateAccountButton.Click();
            Assert.True(RegisterPage.ErrorMessage.Displayed);

            RegisterPage.FillTheFirstNameField();
            RegisterPage.EmailField.Clear();
            RegisterPage.FillThePasswordField();
            RegisterPage.FillTheConfirmPasswordField();
            RegisterPage.CreateAccountButton.Click();
            Assert.True(RegisterPage.ErrorMessage.Displayed);
        }

        [Test]
        public void RegisterNewPhotographer_Positive()
        {
            RegisterPage = new RegisterPage(driver);
            RegisterPage.GoToPage();

            RegisterPage.FillTheFirstNameField();
            RegisterPage.FillTheEmailField();
            RegisterPage.FillThePasswordField();
            RegisterPage.FillTheConfirmPasswordField();
            RegisterPage.AcceptTermCheckBox.Click();
            CreateBusinessProfilePage =  RegisterPage.CreateAccountButtonClick();
            Assert.True(CreateBusinessProfilePage.PageTitle.Text.Contains("Create a public business profile"));

            CreateBusinessProfilePage.BusinessNameField.GetCssValue()
            
        }


    }
}
