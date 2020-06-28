using HomeworkSeleniumAdvanced.DemoQA.Pages;
using HomeworkSeleniumAdvanced.DemoQA.Pages.HomePage;
using NUnit.Framework;

namespace HomeworkSeleniumAdvanced.DemoQA.Tests
{
    [TestFixture]
    public class NavigationTests : BaseTest
    {
        private HomePage _homePage;
        private DemoQAPage _demoQAPage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _homePage = new HomePage(Driver);
            _demoQAPage = new DemoQAPage(Driver);
            _homePage.NavigateTo();
            Driver.Manage().Window.Maximize();                       
        }

        [Test] 
        [TestCase("Sortable")]
        [TestCase("Selectable")]
        [TestCase("Droppable")]
        [TestCase("Dragabble")]
        [TestCase("Resizable")]

        public void NavigateToCategory (string categoryName)
        {                        
            _homePage.ScrollTo(_homePage.CategoryCards("Interactions")).Click();
            _demoQAPage.ScrollTo(_demoQAPage.SidebarInteractionsMenu);
            _demoQAPage.ScrollTo(_demoQAPage.SubMenu(categoryName)).Click();
                                             
            _demoQAPage.AsertPageTitle(categoryName);
        }

        [TearDown]

        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
