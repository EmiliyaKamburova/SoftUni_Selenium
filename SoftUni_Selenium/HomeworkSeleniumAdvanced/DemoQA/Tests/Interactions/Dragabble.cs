using HomeworkSeleniumAdvanced.DemoQA.Pages.DragabblePage;
using HomeworkSeleniumAdvanced.DemoQA.Tests;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace HomeworkSeleniumAdvanced.DemoQA
{
    [TestFixture]
    public class Dragabble: BaseTest
    {
        private DragabblePage _dragabblePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _dragabblePage = new DragabblePage(Driver);
            _dragabblePage.NavigateTo();
        }

        [Test] 
        public void CheckPositionIsCorrect_When_DragElement()
        {
           
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                    
            Builder
                .MoveToElement (_dragabblePage.DragMeElement)
                .DragAndDropToOffset(_dragabblePage.DragMeElement, 300, 150)
                .Build ()
                .Perform();

            double dragElementPosX = _dragabblePage.DragMeElement.Location.X;
            double dragElementPosY = _dragabblePage.DragMeElement.Location.Y;


            Assert.AreEqual (590, dragElementPosX,3);
            Assert.AreEqual (485, dragElementPosY,3);
                                 
        }

        [Test]
        public void CheckElementIsXAxisRestricted_When_DragXOnlyElement()
        {
          
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(6);

            _dragabblePage.AxisXTab.Click();

            var elementPosXBefore = _dragabblePage.OnlyXElement.Location.X;
            var elementPosYBefore = _dragabblePage.OnlyXElement.Location.Y;

            Builder
                .ClickAndHold(_dragabblePage.OnlyXElement)
                .MoveByOffset(300, 100)
                .Release()
                .Build()
                .Perform();

            var elementPosXAfter = _dragabblePage.OnlyXElement.Location.X;
            var elementPosYAfter = _dragabblePage.OnlyXElement.Location.Y;

            Assert.IsTrue(elementPosYBefore == elementPosYAfter);
            Assert.AreNotEqual(elementPosXBefore, elementPosXAfter);
           
        }

        [Test]
        public void CheckElementIsYAxisRestricted_When_DragYOnlyElement ()
        {           
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                        
            Driver.ScrollTo(_dragabblePage.AxisXTab);
            _dragabblePage.AxisXTab.Click();
                        
            var elementPosXBefore = _dragabblePage.OnlyYElement.Location.X;
            var elementPosYBefore = _dragabblePage.OnlyYElement.Location.Y;

            Builder
                .ClickAndHold(_dragabblePage.OnlyYElement)
                .MoveByOffset(200, 200)
                .Release()
                .Build()
                .Perform();

            var elementPosXAfter = _dragabblePage.OnlyYElement.Location.X;
            var elementPosYAfter = _dragabblePage.OnlyYElement.Location.Y;

            Assert.IsTrue(elementPosXBefore == elementPosXAfter);
            Assert.AreNotEqual(elementPosYBefore, elementPosYAfter);           
        }

        [Test]
        public void CheckElementIsStillInBox_When_DragAndDropOutOfBox ()
        {          
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(6);

            _dragabblePage.ContainerRestrictionTab.Click();                     

            Builder
                .DragAndDropToOffset (_dragabblePage.DragabbleElement,0, _dragabblePage.Container.Size.Height-100)
                .Perform();

            Assert.IsNotNull(_dragabblePage.Container.FindElement(By.TagName("div")));
        }


        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
