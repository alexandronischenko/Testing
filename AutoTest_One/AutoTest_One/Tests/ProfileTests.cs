using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using AutoTest_One.Models;
using NUnit.Framework;

namespace AutoTest_One.Tests
{
    public class ProfileTests : AuthBase
    {
        public static IEnumerable<ProfileData> GroupDataFromXmlFile()
        {
            var path =
                @"/Users/alexandronischenko/RiderProjects/GeneratorTestData/GeneratorTestData/bin/Debug/net6.0/profileData.xml";
            var stream = new StreamReader(path);
            var serializer = new XmlSerializer(typeof(List<ProfileData>));
            var data = serializer.Deserialize(stream) as List<ProfileData>;
            return data;
        }
        
        [Test, TestCaseSource(nameof(GroupDataFromXmlFile))]
        public void ProfileDataTest(ProfileData newProfileData)
        {
            ApplicationManager.NavigationHelper.GoHomePage();
            ApplicationManager.NavigationHelper.GoProfilePage();
            ApplicationManager.ProfileHelper.EnterProfileData(newProfileData);
            ApplicationManager.ProfileHelper.ClickUpdateChanges();
            var profileData = ApplicationManager.ProfileHelper.GetProfileData();
            Assert.AreEqual(newProfileData.FirstName, profileData.FirstName);
            Assert.AreEqual(newProfileData.LastName, profileData.LastName);
            Assert.AreEqual(newProfileData.Phone, profileData.Phone);
            Assert.AreEqual(newProfileData.AddressStreet, profileData.AddressStreet);
            Assert.AreEqual(newProfileData.AddressZipcode, profileData.AddressZipcode);
            Assert.AreEqual(newProfileData.CompanyName, profileData.CompanyName);
        }
    }
}