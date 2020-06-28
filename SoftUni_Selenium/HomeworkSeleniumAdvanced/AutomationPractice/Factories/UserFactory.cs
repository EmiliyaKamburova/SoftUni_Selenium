using HomeworkSeleniumAdvanced.AutomationPractice.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkSeleniumAdvanced.AutomationPractice.Factories
{
    public static class UserFactory
    {
        public static RegistrationUserModel Create()
        {
            return new RegistrationUserModel
            {
                FirstName = "John",
                LastName = "Man",
                Email = "sash@gmail.com",
                Gender = "Male",
                Password = "abc12345678",
                Address = "101, Main Str.",
                City = "Martinsburg",
                State = "Alabama",
                Zip = "25401",
                Country = "United States",
                MobilePhone = "0123456789",
                AliasAddress = "1, Lama Str."

            };
        }
    }
}
