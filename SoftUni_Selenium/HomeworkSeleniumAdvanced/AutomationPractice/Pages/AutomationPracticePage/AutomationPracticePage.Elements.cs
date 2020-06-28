using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace HomeworkSeleniumAdvanced.AutomationPractice.Pages
{
    public partial class AutomationPracticePage
    {
     public  IWebElement LoginButton => Driver.FindElement(By.ClassName("login"));
     public  IWebElement EmailFieldCreateAccount => Driver.FindElement(By.Id("email_create"));
     public  IWebElement CreateAccountButton => Driver.FindElement(By.Id("SubmitCreate"));
     public  IWebElement ValidateEmailField => Driver.FindElement(By.XPath("//*[@id='create_account_error']/ol/li"));
        [System.Obsolete]
     public  IWebElement ValidateFirstNameField => Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("customer_firstname")));
     public  IWebElement ValidateLastNameField => Driver.FindElement(By.Id("customer_lastname"));
     public  IWebElement ValidateEnteredEmailField => Driver.FindElement(By.Id("email"));       
     public IWebElement ValidatePasswordField => Driver.FindElement(By.Id("passwd"));
     public IWebElement ValidateAddressField => Driver.FindElement(By.Id("address1"));
     public IWebElement ValidateCityField => Driver.FindElement(By.Id("city"));
     public IWebElement ValidateStateField => Driver.FindElement(By.Id("id_state"));
     public IWebElement ValidateZipField => Driver.FindElement(By.Id("postcode"));
     public IWebElement ValidateCountryField => Driver.FindElement(By.Id("id_country"));
     public IWebElement ValidateMobilePhoneField => Driver.FindElement(By.Id("phone_mobile"));
     public IWebElement ValidateAliasAddressField => Driver.FindElement(By.Id("alias"));
     public IWebElement RegistrationButton => Driver.FindElement(By.Id("submitAccount"));
     public IWebElement Error => Driver.FindElement(By.CssSelector("#center_column > div > ol > li"));
    }
}
