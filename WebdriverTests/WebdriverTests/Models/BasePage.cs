using WebdriverTests.Config;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Chrome;
using System;

namespace WebdriverTests.Models
{
    public abstract class BasePage
    {
        public abstract string Url { get; }

        public BasePage(IWebDriver driver, bool forceLoad)
        {
            if (forceLoad)
            {
                driver.Navigate().GoToUrl(Url);
            }

            WaitUntilLoaded(driver);
        }


        public abstract void WaitUntilLoaded(IWebDriver driver);
    }
}
