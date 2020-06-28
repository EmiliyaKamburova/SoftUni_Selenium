using HomeworkSeleniumAdvanced.DemoQA.Models;
using OpenQA.Selenium;

namespace HomeworkSeleniumAdvanced.DemoQA.Pages.PracticeForm
{
    public partial class PracticeFormPage: BasePage 
        
    {
        public PracticeFormPage(IWebDriver driver)
           :base (driver)
        {
           
        }

        public override string Url => "http://demoqa.com/automation-practice-form";

        public void FillForm(PracticeFormModel user)
        {
            FirstName.SendKeys(user.FirstName);
            LastName.SendKeys(user.LastName);
            Email.SendKeys(user.Email);
            Gender(user.Gender).Click();
            PhoneNumber.SendKeys(user.PhoneNumber);
            ScrollTo(SportsCheckBox).Click();
            ScrollTo(Submit).Click();

        }

    }
}
