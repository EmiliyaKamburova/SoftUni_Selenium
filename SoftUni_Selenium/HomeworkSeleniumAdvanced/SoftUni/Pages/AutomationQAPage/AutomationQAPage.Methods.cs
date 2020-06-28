using OpenQA.Selenium;

namespace HomeworkSeleniumAdvanced.SoftUni.Pages.QAAutomation
{
    public partial class AutomationQAPage : BasePage
    {
        public AutomationQAPage(IWebDriver driver) : base (driver)
        {
        }
        public override string Url => "http://www.softuni.bg";

        public void NavigateToAutomationQACourse()
        {
            NavigationMenuStudies.Click();
            AllActiveModules.Click();
            QaAutomationCourseLink.Click();
            ScrollTo(QaAutomationTab).Click();
        }
    }
}
