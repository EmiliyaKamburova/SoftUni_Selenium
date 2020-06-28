using OpenQA.Selenium;

namespace HomeworkSeleniumAdvanced.DemoQA.Pages
{
    public partial class DemoQAPage: BasePage
    {
        public DemoQAPage(IWebDriver driver) : base (driver)
        {
        }
        public override string Url => "http://demoqa.com/interaction";
    }

 }
