using HomeworkSeleniumAdvanced.DemoQA.Pages.DroppablePage;
using HomeworkSeleniumAdvanced.DemoQA.Tests;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;

namespace HomeworkSeleniumAdvanced.DemoQA

{
    [TestFixture]
    public class Droppable: BaseTest
    {
        private DroppablePage _droppablePage;


        [SetUp]
        public void SetUp()
        {
            Initialize();
            _droppablePage = new DroppablePage(Driver);
            _droppablePage.NavigateTo();
        }

        [Test]
        public void TargetElementColorChanged_When_DragAndDropDroppableElement ()
        {        
            var colorDroppableBefore = _droppablePage.DropHereElement.GetCssValue("background-color");
            
            Builder
                .MoveToElement (_droppablePage.DragMeElement)
                .DoubleClick ()
                .DragAndDrop (_droppablePage.DragMeElement, _droppablePage.DropHereElement)
                .Perform();

            var colorDroppableAfter = _droppablePage.DropHereElement.GetCssValue("background-color");

            Assert.AreNotEqual(colorDroppableBefore, colorDroppableAfter);
            Assert.AreEqual("rgba(70, 130, 180, 1)", colorDroppableAfter);
        }

        [Test]
        public void TargetElementColorChanged_When_DragAndDropAcceptableElement()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(6);

            Driver.ScrollTo(_droppablePage.AcceptTab);
            _droppablePage.AcceptTab.Click();
                        
            Builder
                .MoveToElement(_droppablePage.AcceptableElement)
                .ClickAndHold()
                .MoveByOffset(2,2)
                .Perform();

            var classAfterAction = _droppablePage.DropHereElement.GetAttribute("class");
            StringAssert.Contains("ui-droppable-active", classAfterAction);
        }

        [Test]
        public void TargetElementColorNotChanged_When_DragAndDropNotAcceptableElement()
        {
            _droppablePage.AcceptTab.Click();
                                   
            Builder
                .MoveToElement(_droppablePage.NotAcceptableElement)
                .ClickAndHold()
                .MoveByOffset(-5,-5)
                .Perform();
                        
            var classAfterAction = _droppablePage.DropHereElement.GetAttribute("class");
            StringAssert.DoesNotContain(classAfterAction, "ui-droppable-active");
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }

}
