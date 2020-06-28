using OpenQA.Selenium;

namespace HomeworkSeleniumAdvanced.DemoQA.Pages.DroppablePage
{
    public partial class DroppablePage
    {
       public IWebElement DragMeElement => Driver.FindElement(By.Id("draggable"));
       public IWebElement DropHereElement => Driver.FindElement(By.Id("droppable"));

       public  IWebElement AcceptTab => Driver.FindElement(By.Id("droppableExample-tab-accept"));
       public IWebElement AcceptableElement => Driver.FindElement(By.Id("acceptable"));

       public IWebElement NotAcceptableElement => Driver.FindElement(By.Id("notAcceptable"));
    }
}
