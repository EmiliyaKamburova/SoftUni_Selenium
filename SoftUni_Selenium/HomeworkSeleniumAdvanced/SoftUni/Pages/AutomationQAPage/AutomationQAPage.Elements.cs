using OpenQA.Selenium;

namespace HomeworkSeleniumAdvanced.SoftUni.Pages.QAAutomation
{
    public partial class AutomationQAPage
    {
     public IWebElement NavigationMenuStudies 
            => Driver.FindElement(By.XPath("/html/body/div[1]/div[1]/header/nav/div[1]/ul/li[2]/a/span"));
     public IWebElement AllActiveModules 
            => Driver.FindElement(By.XPath("/html/body/div[1]/div[1]/header/nav/div[1]/ul/li[2]/div/div/div[2]/div[2]/div/div[1]/div[3]/div[1]/i"));
    public IWebElement QaAutomationCourseLink
                => Driver.FindElement(By.XPath("/html/body/div[1]/div[1]/header/nav/div[1]/ul/li[2]/div/div/div[2]/div[2]/div/div[1]/div[3]/div[2]/ul/li[1]/a"));
    public IWebElement QaAutomationTab => Driver.FindElement(By.XPath("/html/body/div[2]/div/section[2]/div[2]/div[3]/div/a/div[2]/h4"));

    public IWebElement Header => Driver.FindElement(By.XPath("/html/body/div[2]/header/h1"));    
    }    
}
