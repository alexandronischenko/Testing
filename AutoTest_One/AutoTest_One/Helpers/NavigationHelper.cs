namespace AutoTest_One.Helpers
{
    public class NavigationHelper : HelperBase
    {
        private string _baseUrl;
        public NavigationHelper(ApplicationManager applicationManager, string baseUrl) : base(applicationManager)
        {
            this._baseUrl = baseUrl;
        }
        
        public void GoHomePage()
        {
            Driver.Navigate().GoToUrl("https://swiftbook.ru/");
        }
        
        public void GoLoginPage()
        {
            Driver.Navigate().GoToUrl("https://swiftbook.ru/membership-login/");
        }
        
        public void GoProfilePage()
        {
            Driver.Navigate().GoToUrl("https://swiftbook.ru/membership-login/membership-profile/");
        }
    }
}