using HomeworkSeleniumAdvanced.DemoQA.Pages;
using HomeworkSeleniumAdvanced.DemoQA.Tests;
using NUnit.Framework;

namespace HomeworkSeleniumAdvanced.DemoQA
{
    [TestFixture]
    public class Sortable:BaseTest
    {
        private SortablePage _sortablePage;


        [SetUp]
        public void SetUp()
        {
            Initialize();
            _sortablePage = new SortablePage(Driver);
            _sortablePage.NavigateTo();
        }

        [Test]
        public void OptionPlaceIsChanged_When_OptionIsMovedDown()
        {
            
            Builder
                .MoveToElement(_sortablePage.OptionOne)
                .DragAndDropToOffset(_sortablePage.OptionOne, 0, 50)
                .Perform();

            Assert.AreEqual("One", _sortablePage.OptionOne.Text);                   
        }

        [Test]
        public void OptionPlaceIsChanged_When_OptionIsMovedUp()
        {
            
            Builder
                .MoveToElement(_sortablePage.OptionFour)
                .DragAndDropToOffset(_sortablePage.OptionFour, 0, -100)
                .Perform();

            Assert.AreEqual("Four", _sortablePage.OptionFour.Text);
        }
              
        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
