using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkSeleniumAdvanced.DemoQA.Pages.SelectablePage
{
    public partial class SelectablePage
    {
    public IWebElement FirstSelectableElement => Driver.FindElement(By.XPath("//li[normalize-space(text())='Cras justo odio']"));
    public IWebElement SecondSelectableElement => Driver.FindElement(By.XPath("//li[normalize-space(text())='Dapibus ac facilisis in']"));
    }
}
