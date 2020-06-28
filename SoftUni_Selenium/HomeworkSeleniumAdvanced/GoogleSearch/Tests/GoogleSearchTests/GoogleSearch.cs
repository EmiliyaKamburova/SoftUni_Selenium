using HomeworkSeleniumAdvanced.GoogleSearch.Pages.GoogleSearchPage;
using NUnit.Framework;

namespace HomeworkSeleniumAdvanced.GoogleSearch.Tests.GoogleSearchTests
{
    [TestFixture]
    public class GoogleSearch : BaseTest
    {
        GoogleSearchPage _googleSearchPage;
        
        [SetUp]
        public void SetUp()
        {
            Initialize();
            _googleSearchPage = new GoogleSearchPage(Driver);
            _googleSearchPage.NavigateTo();
            Driver.Manage().Window.Maximize();
        }

        [Test]
        public void VerifyTitleOfFirstResult_When_SearchInGoogle()
        {
            _googleSearchPage.SearchInGoogle();
            _googleSearchPage.WebSite.Click();

            Assert.AreEqual(Driver.Title, "SeleniumHQ Browser Automation");
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
