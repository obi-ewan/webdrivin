using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using WebdriverTests.Models;

namespace WebdriverTests.tests
{
    [TestClass]
    public class HomePageTests : BaseTest
    {
        [TestMethod]
        public void GoToHomePageTest()
        {
            HomePage hp = new HomePage(Driver);
            System.Threading.Thread.Sleep(5);
        }
    }
}
