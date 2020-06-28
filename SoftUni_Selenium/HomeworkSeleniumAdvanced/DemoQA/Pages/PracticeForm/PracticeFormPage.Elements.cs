using OpenQA.Selenium;

namespace HomeworkSeleniumAdvanced.DemoQA.Pages.PracticeForm
{
    public partial class PracticeFormPage : BasePage

    {
        public IWebElement FirstName => Driver.FindElement(By.Id("firstName"));

        public IWebElement LastName => Driver.FindElement(By.Id("lastName"));

        public IWebElement Email => Driver.FindElement(By.Id("userEmail"));

        public IWebElement Gender(string labelText) => Driver.FindElement(By.XPath($"//*[@id='genterWrapper']//label[text()='{labelText}']"));

        public IWebElement PhoneNumber => Driver.FindElement(By.Id("userNumber"));

        public IWebElement SportsCheckBox => Driver.FindElement(By.XPath("//*[@id='hobbiesWrapper']//label[text()='Sports']"));

        public IWebElement Submit => Driver.FindElement(By.Id("submit"));

    }
}
