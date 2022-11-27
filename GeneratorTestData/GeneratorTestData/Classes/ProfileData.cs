using System.Xml.Serialization;

namespace GeneratorTestData.Classes;

public class ProfileData
{
    
    [XmlElement("firstName")] public string FirstName { get; set; }
    [XmlElement("lastName")] public string LastName { get; set; }
    [XmlElement("addressStreet")] public string AddressStreet { get; set; }
    [XmlElement("phone")] public string Phone  { get; set; }
    [XmlElement("addressZipcode")] public string AddressZipcode  { get; set; }
    [XmlElement("companyName")] public string CompanyName { get; set; }

    public ProfileData(string firstName, string lastName, string addressStreet, string phone, string addressZipcode, string companyName)
    {
        FirstName = firstName;
        LastName = lastName;
        AddressStreet = addressStreet;
        Phone = phone;
        AddressZipcode = addressZipcode;
        CompanyName = companyName;
    }

    public ProfileData()
    {
        
    }
}