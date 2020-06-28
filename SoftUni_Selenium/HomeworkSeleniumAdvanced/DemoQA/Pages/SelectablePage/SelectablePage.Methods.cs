using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkSeleniumAdvanced.DemoQA.Pages.SelectablePage
{
    public partial class SelectablePage : BasePage
    {
        public SelectablePage(IWebDriver driver) : base (driver)
        { 
        }
        public override string Url => "http://demoqa.com/selectable";
    }
}
