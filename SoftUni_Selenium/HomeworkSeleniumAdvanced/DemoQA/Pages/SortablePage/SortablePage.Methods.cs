using OpenQA.Selenium;

namespace HomeworkSeleniumAdvanced.DemoQA.Pages
{
    public partial class SortablePage : DemoQAPage
    {
        public SortablePage(IWebDriver driver) : base (driver)
        {                
        }
        public override string Url => "http://demoqa.com/sortable";
    }
}
