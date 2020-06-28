using OpenQA.Selenium;

namespace HomeworkSeleniumAdvanced.GoogleSearch.Pages.GoogleSearchPage
{
    public partial class GoogleSearchPage
    {
     public IWebElement SearchField 
            => Driver.FindElement(By.XPath("//*[@id='tsf']/div[2]/div[1]/div[1]/div/div[2]/input"));        
     public IWebElement GoogleSearchButton
            => Driver.FindElement(By.CssSelector("#tsf > div:nth-child(2) > div.A8SBwf > div.FPdoLc.tfB0Bf > center > input.gNO89b"));
     public IWebElement WebSite 
            => Driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div[9]/div[1]/div[2]/div/div[2]/div[2]/div/div/div[1]/div/div[1]/a/div/cite"));
    }
}
