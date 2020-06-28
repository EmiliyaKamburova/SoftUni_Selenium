using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using System;
using System.IO;
using System.Reflection;

namespace HomeworkSeleniumAdvanced.SoftUni.Tests
{
    [TestFixture]
    public class BaseTest
    {
        protected IWebDriver Driver { get; set; }
        protected Actions Builder { get; set; }

        public void Initialize()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("-headless");
            //Driver = new RemoteWebDriver(new Uri ("http://192.168.0.101:4444/wd/hub"), options); //when we run Selenium Grid server
            
            Driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            Builder = new Actions(Driver);
        }
    }
}
