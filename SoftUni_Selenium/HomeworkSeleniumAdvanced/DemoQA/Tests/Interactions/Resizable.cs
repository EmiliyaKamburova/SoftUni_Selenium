using HomeworkSeleniumAdvanced.DemoQA.Pages.ResizablePage;
using HomeworkSeleniumAdvanced.DemoQA.Tests;
using NUnit.Framework;
using System;

namespace HomeworkSeleniumAdvanced.DemoQA
{
    [TestFixture]
   
    public class Resizable: BaseTest
    {
        private ResizablePage _resizablePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _resizablePage = new ResizablePage(Driver);
            _resizablePage.NavigateTo();
        }

        [Test]
        public void ElementSizeIsMaximal_When_ResizeMoreToMaximum ()
        {                      
            Builder
                .MoveToElement (_resizablePage.ResizableArrow)
                .DragAndDropToOffset(_resizablePage.ResizableArrow, 300, 100)
                .Build ()
                .Perform();

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(6);

            Assert.AreEqual(_resizablePage.ContainerArea.Size.Height, _resizablePage.ResizableBox.Size.Height);
            Assert.AreEqual(_resizablePage.ContainerArea.Size.Width, _resizablePage.ResizableBox.Size.Width);
        }

        [Test]
        public void ElementSizeIsMinimal_When_ResizeMoreToMinimum ()
        {              
            Builder
                .MoveToElement(_resizablePage.ResizableArrow)
                .DragAndDropToOffset(_resizablePage.ResizableArrow, -50,-50)
                .Build()
                .Perform();

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(6);

            Assert.AreEqual(150, _resizablePage.ResizableBox.Size.Height);
            Assert.AreEqual(150, _resizablePage.ResizableBox.Size.Width);
        }

        [Test]
        public void ElementSizeCorrectSize_When_ResizeToAnyPosition()
        {    
            var heightResizableBoxBefore = _resizablePage.ResizableBox.Size.Height; 
            var widthResizableBoxBefore = _resizablePage.ResizableBox.Size.Width; 

            Builder
                .MoveToElement(_resizablePage.ResizableArrow)
                .DragAndDropToOffset(_resizablePage.ResizableArrow, 60, 60)
                .Build()
                .Perform();

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(6);

            Assert.AreEqual(heightResizableBoxBefore + 60, _resizablePage.ResizableBox.Size.Height);
            Assert.AreEqual(widthResizableBoxBefore + 60, _resizablePage.ResizableBox.Size.Width);
        }



        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
