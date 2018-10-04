using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace weddingventure.com.Pages
{
    public class CreateBusinessProfilePage : PageBase
    {
        public CreateBusinessProfilePage(IWebDriver driver) : base(driver){}

        public IWebElement PageTitle => Driver.FindElement(By.XPath("/html/body/section/div/div/div/div/h2"));
        public IWebElement BusinessNameField => Driver.FindElement(By.Id("vendor_sBusinessName"));
        public IWebElement AddressField => Driver.FindElement(By.Id("vendor_sStreetAddress"));
        public IWebElement CityField => Driver.FindElement(By.Id("vendor_sCity"));
        public SelectElement StateListBox => new SelectElement(Driver.FindElement(By.Id("vendor_sState")));
        public IWebElement ZipCodeField => Driver.FindElement(By.Id("vendor_sZipcode"));
        public SelectElement WeddingCategoryListBox => new SelectElement(Driver.FindElement(By.Id("vendor_iPrimaryCategoryUID")));
        public IWebElement WebSiteField => Driver.FindElement(By.Id("vendor_sUrl"));
        public IWebElement PublicAddressField => Driver.FindElement(By.Id("vendor_sPublicEmail"));
        public IWebElement PhoneField => Driver.FindElement(By.Id("vendor_sPhone"));
        public IWebElement CreateAccount => Driver.FindElement(By.Id("accountSubmit"));

        public readonly string City = "New York";
        public readonly string ZipCode = "111000";
        public readonly string Phone = "+79261112233";

        public void FillBusinessNameField()
        {
            BusinessNameField.Clear();
        }

        public void ClearAllInputsOnThePage()
        {
            Driver.FindElements(By.)
        }



    }
}
