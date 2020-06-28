using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkSeleniumAdvanced.GoogleSearch.Pages.GoogleSearchPage
{
    public partial class GoogleSearchPage : BasePage
    {
        public GoogleSearchPage(IWebDriver driver) : base (driver)
        {
        }

        public override string Url => "http://www.google.com";

        public void SearchInGoogle()
        {
            SearchField.Click();
            SearchField.SendKeys("selenium");

            GoogleSearchButton.SendKeys(Keys.Enter);           
        }
    }
}
