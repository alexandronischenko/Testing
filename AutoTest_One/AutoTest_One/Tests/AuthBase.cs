using AutoTest_One.Models;
using NUnit.Framework;

namespace AutoTest_One.Tests
{
    public class AuthBase : TestBase
    {
        [SetUp]
        public override void SetupTest()
        {
            ApplicationManager = ApplicationManager.GetInstance();
            ApplicationManager.NavigationHelper.GoLoginPage();
            var accountData = new AccountData(Settings.Login, Settings.Password);
            ApplicationManager.LoginHelper.Login(accountData);
            ApplicationManager.NavigationHelper.GoHomePage();
        }
        
    }
}