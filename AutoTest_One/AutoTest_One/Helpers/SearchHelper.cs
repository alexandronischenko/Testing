using OpenQA.Selenium;

namespace AutoTest_One.Helpers
{
    public class SearchHelper : HelperBase
    {
        public SearchHelper(ApplicationManager applicationManager) : base(applicationManager)
        {
            
        }
        
        public void Search(string searchString)
        {
            Driver.FindElement(By.XPath("//ul[@id='menu-general-menu']/li[6]")).Click();
            Driver.FindElement(By.XPath("//ul[@id='menu-general-menu']/li[6]/a/div")).Click();
            Driver.FindElement(By.Id("s")).Clear();
            Driver.FindElement(By.Id("s")).SendKeys(searchString);
            Driver.FindElement(By.Id("searchsubmit")).Click();
        }
    }
}