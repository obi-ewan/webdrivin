using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using WebdriverTests.Config;

namespace WebdriverTests.Models
{
    class HomePage : BasePage
    {
        public string url = Settings.BaseUrl;
        public override string Url
        {
            get { return url; }
        }

        public HomePage(IWebDriver driver, bool forceLoad)  : base(driver, forceLoad)
        {
        }

        public override void WaitUntilLoaded(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            bool elementLoaded = wait.Until(d => LocationButton(driver).Displayed);
        }

        // these attributes are nice but don't seem to work :( NullReferenceException city
        //[FindsBy(How = How.ClassName, Using = "uk-redirect-popup__stay-us-button button tertiary")]
        //public IWebElement LocationSelectButton { get; set; }

        public IWebElement LocationButton(IWebDriver driver)
        {
            return driver.FindElement(By.CssSelector(".uk-redirect-popup__stay-us-button"));
        }
    }
}
