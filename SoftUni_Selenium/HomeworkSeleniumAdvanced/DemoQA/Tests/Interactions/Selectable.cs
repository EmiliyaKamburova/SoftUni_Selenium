using HomeworkSeleniumAdvanced.DemoQA.Pages.SelectablePage;
using HomeworkSeleniumAdvanced.DemoQA.Tests;
using NUnit.Framework;

namespace HomeworkSeleniumAdvanced.DemoQA
{
    [TestFixture]
    public class Selectable : BaseTest
    {
        private SelectablePage _selectablePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _selectablePage = new SelectablePage(Driver);
            _selectablePage.NavigateTo();
        }

        [Test]
        public void ElementColorChanged_When_ElementIsSelected()
        {         
            Builder
                .MoveToElement(_selectablePage.FirstSelectableElement)
                .Click()
                .Perform();

            var elementColor = _selectablePage.FirstSelectableElement.GetCssValue("background-color");
            Assert.AreEqual("rgba(0, 123, 255, 1)", elementColor);                                  
        }

        [Test]
        public void SelectedElementsColorChanged_When_MoreThanOneElementIsSelected()
        {            
            Builder
                .MoveToElement(_selectablePage.FirstSelectableElement)
                .Click()
                .MoveToElement (_selectablePage.SecondSelectableElement)
                .Click()
                .Build ()
                .Perform();

            var firstElementColor = _selectablePage.FirstSelectableElement.GetCssValue("background-color");
            var secondElementColor = _selectablePage.SecondSelectableElement.GetCssValue("background-color");
            Assert.AreEqual("rgba(0, 123, 255, 1)", firstElementColor, secondElementColor);
        }     
            
            [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
