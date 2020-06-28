using OpenQA.Selenium;

namespace HomeworkSeleniumAdvanced.DemoQA.Pages
{
    public partial class SortablePage
    {
        public IWebElement OptionFour 
            => Driver.FindElement(By.XPath("//div[@class= 'vertical-list-container mt-4']//div[normalize-space(text())='Four']"));

        public IWebElement OptionOne
            => Driver.FindElement(By.XPath("//div[@class= 'vertical-list-container mt-4']//div[normalize-space(text())='One']"));
    }
}
