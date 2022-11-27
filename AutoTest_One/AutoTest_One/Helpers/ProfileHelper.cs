using AutoTest_One.Models;
using OpenQA.Selenium;

namespace AutoTest_One.Helpers
{
    public class ProfileHelper : HelperBase
    {
        public ProfileHelper(ApplicationManager applicationManager) : base(applicationManager)
        {
            
        }
        
        public void EnterProfileData(ProfileData profileData)
        {
            Driver.FindElement(By.Id("first_name")).Click();
            Driver.FindElement(By.Id("first_name")).Clear();
            Driver.FindElement(By.Id("first_name")).SendKeys(profileData.FirstName);
            
            Driver.FindElement(By.Id("last_name")).Click();
            Driver.FindElement(By.Id("last_name")).Clear();
            Driver.FindElement(By.Id("last_name")).SendKeys(profileData.LastName);
            
            Driver.FindElement(By.Id("phone")).Click();
            Driver.FindElement(By.Id("phone")).Clear();
            Driver.FindElement(By.Id("phone")).SendKeys(profileData.Phone);
            
            Driver.FindElement(By.Id("address_street")).Click();
            Driver.FindElement(By.Id("address_street")).Clear();
            Driver.FindElement(By.Id("address_street")).SendKeys(profileData.AddressStreet);
            
            Driver.FindElement(By.Id("address_zipcode")).Click();
            Driver.FindElement(By.Id("address_zipcode")).Clear();
            Driver.FindElement(By.Id("address_zipcode")).SendKeys(profileData.AddressZipcode);

            Driver.FindElement(By.Id("company_name")).Click();
            Driver.FindElement(By.Id("company_name")).Clear();
            Driver.FindElement(By.Id("company_name")).SendKeys(profileData.CompanyName);
        }

        public void ClickUpdateChanges()
        {
            Driver.FindElement(By.Name("swpm_editprofile_submit")).Click();
        }

        public ProfileData GetProfileData()
        {
            var firstName = Driver.FindElement(By.Id("first_name")).GetAttribute("value");
            var lastName = Driver.FindElement(By.Id("last_name")).GetAttribute("value");
            var addressStreet = Driver.FindElement(By.Id("address_street")).GetAttribute("value");
            var phone = Driver.FindElement(By.Id("phone")).GetAttribute("value");
            var addressZipcode = Driver.FindElement(By.Id("address_zipcode")).GetAttribute("value");
            var companyName = Driver.FindElement(By.Id("company_name")).GetAttribute("value");
            return new ProfileData(firstName, lastName, addressStreet, phone, addressZipcode, companyName);
        }
    }
}