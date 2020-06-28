using HomeworkSeleniumAdvanced.DemoQA.Factories;
using HomeworkSeleniumAdvanced.DemoQA.Models;
using HomeworkSeleniumAdvanced.DemoQA.Pages.PracticeForm;
using NUnit.Framework;


namespace HomeworkSeleniumAdvanced.DemoQA.Tests.Forms
{
    [TestFixture]
    public class PracticeFormTests: BaseTest
    {
        private PracticeFormPage _practiceFormPage;
        private PracticeFormModel _user;
                
        [SetUp]

        public void SetUp()
        {
            Initialize();
            Driver.Navigate().GoToUrl("http://demoqa.com/automation-practice-form");
            Driver.Manage().Window.Maximize();
            _practiceFormPage = new PracticeFormPage(Driver);
            _user = PracticeFormFactory.Create();
        }

        [Test]

        public void ThanksMessageDisplayed_When_FillFormWithValidData ()
        {
            PracticeFormSection popUp = new PracticeFormSection(Driver);
                        
            _practiceFormPage.FillForm(_user);

           // Assert.AreEqual("Thanks for submitting the form", popUp.Message.Text);
        }

        [Test]

        public void ErrorDisplayed_When_FillFormWithoutFirstName()
        {
            //Arrange
            _user.FirstName = string.Empty;

            //Act
            _practiceFormPage.FillForm(_user);

            //Assert
            _practiceFormPage.AssertErrorBorderColor(_practiceFormPage.FirstName);
        }

        [TearDown]

        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
