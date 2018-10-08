using OpenQA.Selenium;
using System;
using weddingventure.com.Data;

namespace weddingventure.com
{
    public class PageBase
    {
        protected IWebDriver Driver { get; }
        protected DataSource Data;
        
        public PageBase(IWebDriver driver)
        {
            Driver = driver;
            Data = new DataSource();
        }

        public void ClearAllInputsOnThePage()
        {
            var inputs = Driver.FindElements(By.TagName("input"));

            foreach (var input in inputs)
            {
                try
                {
                    input.Clear();
                }
                catch (Exception)
                {

                }
            }
        }
    }
}
