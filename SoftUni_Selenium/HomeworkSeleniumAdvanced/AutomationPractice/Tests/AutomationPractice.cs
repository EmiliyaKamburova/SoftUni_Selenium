using HomeworkSeleniumAdvanced.AutomationPractice.Factories;
using HomeworkSeleniumAdvanced.AutomationPractice.Models;
using HomeworkSeleniumAdvanced.AutomationPractice.Pages;
using HomeworkSeleniumAdvanced.AutomationPractice.Tests;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace HomeworkSeleniumAdvanced.AutomationPractice

{
    [TestFixture]
    public class NegativeScenariosRegistrationForm: BaseTest
    {
        private AutomationPracticePage _automationPracticePage;
        private RegistrationUserModel _user;
       

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _automationPracticePage = new AutomationPracticePage(Driver);            
            _automationPracticePage.NavigateTo();
            Driver.Manage().Window.Maximize();

            _automationPracticePage.LoginButton.Click();

            _user = UserFactory.Create();
        }

        [Test]
        public void AutomationPracticeRegistration()
        {
            _automationPracticePage.CreateAccount(_user);
                        
            _automationPracticePage.ScrollTo(_automationPracticePage.ValidateEnteredEmailField).Click();
             Thread.Sleep(2000);
            _automationPracticePage.ValidateEnteredEmailField.SendKeys(Keys.Tab);
                      
            Assert.AreEqual("sash@gmail.com", _automationPracticePage.ValidateEnteredEmailField.GetAttribute("value"));
        }


        [Test]
        public void ValidateEmptyEmailField ()
        {            
            _user.Email = string.Empty;
            
            _automationPracticePage.CreateAccount(_user);

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(6);                      
            Assert.AreEqual("Invalid email address.", _automationPracticePage.ValidateEmailField.Text);
        }
        
        [Test]
        public void ValidateEmptyFirstNameField ()
        {              
            _user.FirstName = string.Empty;

            _automationPracticePage.CreateAccount(_user);
            _automationPracticePage.FillForm(_user);
                        
            Assert.AreEqual("firstname is required.", _automationPracticePage.Error.Text);
        }

        [Test]
        public void ValidateEmptyLastNameField ()
        {                   
            _user.LastName = string.Empty;

            _automationPracticePage.CreateAccount(_user);
            _automationPracticePage.FillForm(_user);
                        
            Assert.AreEqual("lastname is required.", _automationPracticePage.Error.Text);
        }


        [Test]
        public void ValidateEmptyPasswordField ()
        {                    
            _user.Password = string.Empty;

            _automationPracticePage.CreateAccount(_user);
            _automationPracticePage.FillForm(_user);
                        
            Assert.AreEqual("passwd is required.", _automationPracticePage.Error.Text);
        }


        [Test]
        public void ValidateEmptyAddressField ()
        {                  
            _user.Address = string.Empty;

            _automationPracticePage.CreateAccount(_user);
            _automationPracticePage.FillForm(_user);
                        
            Assert.AreEqual("address1 is required.", _automationPracticePage.Error.Text);
        }
        [TearDown]

        public void TearDown()
        {
            Driver.Quit();
        }

    }

}
