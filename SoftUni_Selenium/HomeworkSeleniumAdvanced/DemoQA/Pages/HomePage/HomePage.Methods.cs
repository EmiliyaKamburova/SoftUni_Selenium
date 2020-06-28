using OpenQA.Selenium;

namespace HomeworkSeleniumAdvanced.DemoQA.Pages.HomePage
{
    public partial class HomePage : BasePage
    {
        public HomePage(IWebDriver driver): base (driver)
        {
        }

        public override string Url => "http://demoqa.com/";
    }
}
