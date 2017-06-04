using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebdriverTests.Models;

namespace WebdriverTests.tests
{
    [TestClass]
    public class HomePageTests : BaseTest
    {
        [TestMethod]
        public void GoToHomePageTest()
        {
            HomePage hp = new HomePage(Driver, true);
            hp.LocationButton(Driver).Click();

            Assert.IsTrue(Driver.Title == "banana", "Title was actually; " + Driver.Title);
        }
    }
}
