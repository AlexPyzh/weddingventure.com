using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using NUnit.Framework;
using weddingventure.com.Pages;

namespace weddingventure.com.Tests
{
    [TestFixture]
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
            RegisterPage.ClearAllInputsOnThePage();
            
            RegisterPage.FirstNameField.SendKeys(Data.firstName);
            RegisterPage.EmailField.SendKeys(Data.email);
            RegisterPage.PasswordField.SendKeys(Data.password);
            RegisterPage.ConfirmPasswordField.SendKeys(Data.password);
            RegisterPage.AcceptTermCheckBox.Click();
            CreateBusinessProfilePage =  RegisterPage.CreateAccountButtonClick();
            
            //   Assert.True(CreateBusinessProfilePage.PageTitle.Text.Contains("Create a public business profile"));

            CreateBusinessProfilePage.ClearAllInputsOnThePage();
            CreateBusinessProfilePage.BusinessNameField.SendKeys(Data.firstName);
            CreateBusinessProfilePage.CityField.SendKeys(Data.City);
            CreateBusinessProfilePage.StateListBox.SelectByText("Alabama");
            CreateBusinessProfilePage.ZipCodeField.SendKeys(Data.ZipCode);
            CreateBusinessProfilePage.WeddingCategoryListBox.SelectByText("Photographer");
            CreateBusinessProfilePage.PublicEmailAddressField.SendKeys(Data.email_3);
            CreateBusinessProfilePage.PhoneField.SendKeys(Data.Phone);
            CreateBusinessProfilePage.CreateAccount.Click();
        }

        [Test]
        public void SignInAsVendor()
        {
            PageWithRegisterLink = new PageWithRegisterLink(driver);
            PageWithRegisterLink.GoToPage();

            SignInPage = PageWithRegisterLink.LoginLinkClick();
            SignInPage.EmailField.SendKeys(Data.email);
            SignInPage.PasswordField.SendKeys(Data.password);
            SignInPage.EnterButton.Click();
        }

        [Test]
        public void Test()
        {

        }

       

    }
}
