using NUnit.Framework;

namespace HomeworkSeleniumAdvanced.DemoQA.Pages
{
    public partial class DemoQAPage
    {
        public void AsertPageTitle (string expectedTitle)
        {
            Assert.AreEqual(expectedTitle,PageTitle.Text);
        }
    }
}
