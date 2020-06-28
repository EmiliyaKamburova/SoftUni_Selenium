using OpenQA.Selenium;

namespace HomeworkSeleniumAdvanced.DemoQA.Pages.DroppablePage
{
    public partial class DroppablePage: BasePage 
    {
        public DroppablePage(IWebDriver driver) : base (driver)
        {
        }
        public override string Url => "http://demoqa.com/droppable";
    }
}
