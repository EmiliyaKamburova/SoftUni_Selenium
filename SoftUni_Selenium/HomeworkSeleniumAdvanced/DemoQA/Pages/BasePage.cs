using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace HomeworkSeleniumAdvanced.DemoQA.Pages
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

        public void WaitForLoad(int timeoutSec = 15)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            WebDriverWait wait = new WebDriverWait(Driver, new TimeSpan(0, 0, timeoutSec));
            wait.Until(wd => js.ExecuteScript("return document.readyState").ToString() == "complete");
        }
    }
}
