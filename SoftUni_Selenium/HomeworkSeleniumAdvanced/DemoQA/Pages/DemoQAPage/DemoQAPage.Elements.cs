using OpenQA.Selenium;
using System;

namespace HomeworkSeleniumAdvanced.DemoQA.Pages
{
    public partial class DemoQAPage
    {
        //protected IWebElement LeftPanel => Driver.FindElement(By.XPath("//div[@class = 'left-pannel']"));
       
       // public IWebElement InteractionsButton => LeftPanel.FindElement(By.XPath(".//*[normalize-space(text())='Interactions']"));
        
        //public IWebElement SubMenu (string categoryName) => LeftPanel.FindElement(By.XPath($".//*[normalize-space(text())='{categoryName}']"));
        
        public IWebElement SidebarInteractionsMenu => Driver.FindElement(By.XPath("//*[normalize-space(text())='Interactions']/ancestor::div[@class='element-group']//li"));
                    
        public IWebElement SubMenu(string categoryName) => SidebarInteractionsMenu.FindElement(By.XPath($"//*[normalize-space(text())='{categoryName}']"));
        
        public IWebElement PageTitle => Driver.FindElement(By.ClassName("main-header"));
    }
}
