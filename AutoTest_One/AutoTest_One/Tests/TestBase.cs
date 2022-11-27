using NUnit.Framework;

namespace AutoTest_One.Tests
{
    public class TestBase
    {
        protected ApplicationManager ApplicationManager;
        
        [SetUp]
        public virtual void SetupTest()
        {
            ApplicationManager = ApplicationManager.GetInstance();
            ApplicationManager.NavigationHelper.GoHomePage();
        }
    }
}