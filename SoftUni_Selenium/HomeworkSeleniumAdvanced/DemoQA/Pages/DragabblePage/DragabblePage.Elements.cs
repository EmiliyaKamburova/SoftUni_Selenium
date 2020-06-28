using OpenQA.Selenium;

namespace HomeworkSeleniumAdvanced.DemoQA.Pages.DragabblePage
{
    public partial class DragabblePage
    {
     public IWebElement DragMeElement => Driver.FindElement(By.XPath("//*[@id='dragBox']"));
     public IWebElement AxisXTab => Driver.FindElement(By.Id("draggableExample-tab-axisRestriction"));
     public IWebElement OnlyXElement => Driver.FindElement(By.XPath("//*[@id='restrictedX']"));
     public IWebElement OnlyYElement => Driver.FindElement(By.Id("restrictedY"));
     public IWebElement ContainerRestrictionTab => Driver.FindElement(By.Id("draggableExample-tab-containerRestriction"));
     public IWebElement Container =>  Driver.FindElement(By.XPath("//*[@id='containmentWrapper']"));
     public IWebElement DragabbleElement => Driver.FindElement(By.XPath("//*[@id='containmentWrapper']/div"));
    }
}
