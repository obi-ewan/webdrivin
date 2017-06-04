using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using WebdriverTests.Config;

namespace WebdriverTests.Models
{
    class HomePage : BasePage
    {
        // url of homepage
        public string url = Settings.BaseUrl;
        public override string Url { get { return url; } }

        public HomePage(IWebDriver driver, bool forceLoad)  : base(driver, forceLoad) { }

        public override void WaitUntilLoaded(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            bool elementLoaded = wait.Until(d => LocationButton(driver).Displayed);
        }

        public IWebElement LocationButton(IWebDriver driver)
        {
            return driver.FindElement(By.CssSelector(".uk-redirect-popup__stay-us-button"));
        }

        // these attributes are nice but need to be done in a way that doesn't throw NullReferenceException 
        [FindsBy(How = How.CssSelector, Using = ".uk-redirect-popup__stay-us-button")]
        public IWebElement LocationSelectButton { get; set; }
    }
}
