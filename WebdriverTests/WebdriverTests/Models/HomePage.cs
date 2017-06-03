using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using WebdriverTests.Config;

namespace WebdriverTests.Models
{
    class HomePage : BasePage
    {
        public string url = Settings.BaseUrl;

        public HomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            driver.Navigate().GoToUrl(url);
        }
    }
}
