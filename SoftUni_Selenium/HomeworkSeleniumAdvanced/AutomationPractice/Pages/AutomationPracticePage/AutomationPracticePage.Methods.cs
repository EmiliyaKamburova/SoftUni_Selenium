using HomeworkSeleniumAdvanced.AutomationPractice.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace HomeworkSeleniumAdvanced.AutomationPractice.Pages
{
    public partial class AutomationPracticePage : BasePage
    {
        public AutomationPracticePage(IWebDriver driver): base (driver)
        {
        }

        public override string Url => "http://automationpractice.com/index.php";

        public void FillForm (RegistrationUserModel user)
        {           
            //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(6);
            ValidateFirstNameField.Click();
            ValidateFirstNameField.SendKeys(user.FirstName + Keys.Tab);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            ScrollTo(ValidateLastNameField).Click();
            ValidateLastNameField.SendKeys(user.LastName + Keys.Tab);            
            ValidateEnteredEmailField.Click();
            ValidatePasswordField.SendKeys(user.Password);
            ValidateAddressField.SendKeys(user.Address);
            ValidateCityField.SendKeys(user.City);
            SelectElement state = new SelectElement(ValidateStateField);
            state.SelectByValue("1");
            ValidateZipField.SendKeys(user.Zip);
            ValidateCountryField.SendKeys(user.Country);
            ValidateMobilePhoneField.SendKeys(user.MobilePhone);
            ValidateAliasAddressField.SendKeys(user.AliasAddress + Keys.Tab);
            RegistrationButton.Click();
        }
        
        public void CreateAccount (RegistrationUserModel user)
        {
            EmailFieldCreateAccount.SendKeys(user.Email);
            EmailFieldCreateAccount.Submit();
            CreateAccountButton.Click();             
        } 
    }
}
