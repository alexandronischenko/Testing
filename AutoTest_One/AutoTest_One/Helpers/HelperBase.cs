using OpenQA.Selenium;

namespace AutoTest_One.Helpers
{
    public class HelperBase
    {
        private ApplicationManager _applicationManager;
        protected readonly IWebDriver Driver;
        private bool _acceptNextAlert = true;

        protected HelperBase(ApplicationManager applicationManager)
        {
            this._applicationManager = applicationManager;
            this.Driver = applicationManager.Driver;
        }
        
        private bool IsElementPresent(By by)
        {
            try
            {
                Driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        
        private bool IsAlertPresent()
        {
            try
            {
                Driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
        
        private string CloseAlertAndGetItsText() {
            try {
                IAlert alert = Driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (_acceptNextAlert) {
                    alert.Accept();
                } else {
                    alert.Dismiss();
                }
                return alertText;
            } finally {
                _acceptNextAlert = true;
            }
        }
    }
}