using OpenQA.Selenium;

namespace HomeworkSeleniumAdvanced.DemoQA.Pages.ResizablePage
{
    public partial class ResizablePage
    {
    public IWebElement ContainerArea => Driver.FindElement(By.ClassName("constraint-area"));
    public IWebElement ResizableBox => Driver.FindElement(By.Id("resizableBoxWithRestriction"));
    public IWebElement ResizableArrow => Driver.FindElement(By.XPath("//span[contains(@class ,'react-resizable-handle')]"));
    }
}
