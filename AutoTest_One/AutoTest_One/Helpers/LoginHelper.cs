using AutoTest_One.Models;
using OpenQA.Selenium;

namespace AutoTest_One.Helpers
{
    public class LoginHelper : HelperBase
    {
        private bool isLoggedIn { get; set; }
        private string Username { get; set; }

        public LoginHelper(ApplicationManager applicationManager) : base(applicationManager)
        {
            isLoggedIn = false;
        }

        public void Login(AccountData accountData)
        {
            if (isLoggedIn)
            {
                if (IsLoggedIn(accountData.Username))
                {
                    return;
                }
                Logout();
            }

            Driver.FindElement(By.Id("swpm_user_name")).Click();
            Driver.FindElement(By.Id("swpm_user_name")).Clear();
            Driver.FindElement(By.Id("swpm_user_name")).SendKeys(accountData.Username);
            Driver.FindElement(By.Id("swpm_password")).Click();
            Driver.FindElement(By.Id("swpm_password")).Clear();
            Driver.FindElement(By.Id("swpm_password")).SendKeys(accountData.Password);
            Driver.FindElement(By.Name("swpm-login")).Click();
            isLoggedIn = true;
            Username = accountData.Username;
        }

        public void Logout()
        {
            // Driver.Navigate().GoToUrl("https://swiftbook.ru/");
            // Driver.FindElement(By.LinkText("Выйти")).Click();
            Driver.Navigate().GoToUrl("https://swiftbook.ru/membership-login/membership-profile/");
            
            Driver.FindElement(By.XPath("//div[@id='post-1479']/div/div/div/div[2]/div/div/div/div/div/div[5]/a")).Click();
            isLoggedIn = false;
            Username = "";
        }

        public bool IsLoggedIn()
        {
            return isLoggedIn;
        }

        private bool IsLoggedIn(string newUsername)
        {
            return newUsername == Username;
        }
    }
}