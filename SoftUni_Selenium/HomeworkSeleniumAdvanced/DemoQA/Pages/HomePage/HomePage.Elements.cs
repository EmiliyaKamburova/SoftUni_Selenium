using OpenQA.Selenium;

namespace HomeworkSeleniumAdvanced.DemoQA.Pages.HomePage
{
    public partial class HomePage: BasePage
    {
        public IWebElement CategoryCards(string categoryName) 
            => Driver.FindElement(By.XPath($"//h5[normalize-space(text())='{categoryName}']/ancestor::*[@class='card mt-4 top-card']"));
    }
}
