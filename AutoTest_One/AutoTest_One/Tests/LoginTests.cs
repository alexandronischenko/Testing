using AutoTest_One.Models;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AutoTest_One.Tests
{
    public class LoginTests : TestBase
    {
        [Test]
        public void LoginTest()
        {
            ApplicationManager.LoginHelper.Logout();
            ApplicationManager.NavigationHelper.GoLoginPage();
            var accountData = new AccountData("alex12345", "qwerty1!");
            ApplicationManager.LoginHelper.Login(accountData);
            ApplicationManager.NavigationHelper.GoHomePage();
        }

        [Test]
        public void LoginWithValidData()
        {
            ApplicationManager.LoginHelper.Logout();
            ApplicationManager.NavigationHelper.GoLoginPage();
            var accountData = new AccountData("alex12345", "qwerty1!");
            ApplicationManager.LoginHelper.Login(accountData);
            ApplicationManager.NavigationHelper.GoHomePage();
            Assert.Equals(Settings.Login,
                ApplicationManager.Driver.FindElement(By.Id("menu-item-1760")).GetAttribute("value"));
            ApplicationManager.Driver.FindElement(By.ClassName("swpm-logged-status-value swpm-logged-value")).GetAttribute("value");
        }

        [Test]
        public void LoginWithInvalidData()
        {
            ApplicationManager.LoginHelper.Logout();
            ApplicationManager.NavigationHelper.GoLoginPage();
            var accountData = new AccountData("alex1234567", "qwerty1!");
            ApplicationManager.LoginHelper.Login(accountData);
            Assert.Equals("Пользователь не найден.", ApplicationManager.LoginHelper.UserNotFound());
        }
    }
}