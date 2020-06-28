using OpenQA.Selenium;


namespace HomeworkSeleniumAdvanced.DemoQA.Pages.DragabblePage
{
    public partial class DragabblePage : BasePage
    {
        public DragabblePage(IWebDriver driver) : base (driver)
        {
        }
        public override string Url => "http://demoqa.com/dragabble";
    }
}
