using HomeworkSeleniumAdvanced.SoftUni.Pages.QAAutomation;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System.IO;

namespace HomeworkSeleniumAdvanced.SoftUni.Tests.AutomationQATests
{
    [TestFixture]
    public class AutomationQA: BaseTest
    {
        private AutomationQAPage _automationQAPage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _automationQAPage = new AutomationQAPage(Driver);
            _automationQAPage.NavigateTo();
            Driver.Manage().Window.Maximize();
        }

        [Test]
          public void VerifyAutomationQACourseHeader()
        {
           _automationQAPage.NavigateToAutomationQACourse();       

           Assert.AreEqual("QA Automation - май 2020", _automationQAPage.Header.Text);                    
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string dirPath = Path.GetFullPath(@"..\..\..\", Directory.GetCurrentDirectory());
                var screenshot = ((ITakesScreenshot)Driver).GetScreenshot();
                screenshot.SaveAsFile($"{dirPath}\\SoftUni\\Screenshots\\{TestContext.CurrentContext.Test.Name}.png", ScreenshotImageFormat.Png);
            }
          Driver.Quit();
        }
    }
}
