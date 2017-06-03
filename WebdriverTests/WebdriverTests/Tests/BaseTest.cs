using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebdriverTests
{
    public class BaseTest
    {
        static IWebDriver driver = new ChromeDriver();

        public static IWebDriver Driver
        {
            get { return driver; }
        }
 
        [TestInitialize]
        public void Setup()
        {
            driver.Navigate();
        }

        [TestCleanup]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
