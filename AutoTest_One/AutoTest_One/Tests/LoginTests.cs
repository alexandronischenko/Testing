using AutoTest_One.Models;
using NUnit.Framework;

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
        }

        [Test]
        public void LoginWithInvalidData()
        {
            ApplicationManager.LoginHelper.Logout();
            ApplicationManager.NavigationHelper.GoLoginPage();
            var accountData = new AccountData("alex1234567", "qwerty1!");
            ApplicationManager.LoginHelper.Login(accountData);
            ApplicationManager.NavigationHelper.GoHomePage();
        }
    }
}