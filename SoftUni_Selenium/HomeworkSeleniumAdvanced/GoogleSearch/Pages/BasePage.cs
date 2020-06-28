using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace HomeworkSeleniumAdvanced.GoogleSearch.Pages
{
    public abstract class BasePage
    {
        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(4));
        }

        public IWebDriver Driver { get; }
        public WebDriverWait Wait { get; }

        public virtual string Url { get; }

        public void NavigateTo()
        {
            Driver.Navigate().GoToUrl(Url);
        }

        public IWebElement ScrollTo(IWebElement element)
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            return element;
        }
      
    }
}
