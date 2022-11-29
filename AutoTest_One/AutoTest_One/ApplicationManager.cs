using System;
using System.ComponentModel;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using AutoTest_One.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutoTest_One
{
    public class ApplicationManager
    {
        private IWebDriver _driver;
        private StringBuilder _verificationErrors;
        private string _baseUrl;

        private NavigationHelper _navigationHelper;
        private LoginHelper _loginHelper;
        private SearchHelper _searchHelper;
        private ProfileHelper _profileHelper;

        public IWebDriver Driver => _driver;
        
        private static ThreadLocal<ApplicationManager> app = new ThreadLocal<ApplicationManager>();

        public NavigationHelper NavigationHelper => _navigationHelper;

        public LoginHelper LoginHelper => _loginHelper;

        public SearchHelper SearchHelper => _searchHelper;

        public ProfileHelper ProfileHelper => _profileHelper;

        private ApplicationManager()
        {
            _driver = new ChromeDriver("/Users/alexandronischenko/RiderProjects/Testing/Testing/AutoTest_One/packages/Selenium.WebDriver.ChromeDriver.106.0.5249.6100/driver/mac64arm/");
            _baseUrl = "https://www.google.com/";
            _verificationErrors = new StringBuilder();
            _navigationHelper = new NavigationHelper(this, _baseUrl);
            _loginHelper = new LoginHelper(this);
            _searchHelper = new SearchHelper(this);
            _profileHelper = new ProfileHelper(this);
        }
        
        ~ApplicationManager()
        {
            try
            {
                _driver.Quit();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        
        public void Stop()
        {
            _driver.Quit();
        }
        
        public static ApplicationManager GetInstance()
        {
            if (!app.IsValueCreated)
            {
                var newInstance = new ApplicationManager();
                newInstance._navigationHelper.GoHomePage();
                app.Value = newInstance;
            }
            return app.Value;
        }
    }
}