using NUnit.Framework;
using OpenQA.Selenium;

namespace HomeworkSeleniumAdvanced.DemoQA.Pages.PracticeForm
{
    public partial class PracticeFormPage: BasePage 
        
    {
        public void AssertErrorBorderColor(IWebElement element)
        {
            this.WaitForLoad();
            Assert.AreEqual("rgb(220, 53, 69)", element.GetCssValue("border-color"));
        }
        
        public void AssertSuccessBorderColor(IWebElement element)
        {
            this.WaitForLoad();
            Assert.AreEqual("rgb(40, 167, 69)", element.GetCssValue("border-color"));
        }
    }
}
