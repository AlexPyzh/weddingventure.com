using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace weddingventure.com
{
    public abstract class PageBase
    {
        public PageBase(IWebDriver driver)
        {
            Driver = driver;
        }

        protected IWebDriver Driver { get; }
    }
}
