using HomeworkSeleniumAdvanced.DemoQA.Models;

namespace HomeworkSeleniumAdvanced.DemoQA.Factories
{
    public static class PracticeFormFactory
    {
        public static PracticeFormModel Create()
        {
            return new PracticeFormModel
            {
                FirstName = "John",
                LastName = "Man",
                Email = "sash@gmail.com",
                Gender = "Female",
                PhoneNumber = "0123456789"
            };
        }
           
    }
}
