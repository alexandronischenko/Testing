using System.Xml.Serialization;

namespace AutoTest_One.Models
{
    public class ProfileData
    {
        [XmlElement("firstName")]
        public string FirstName;
        [XmlElement("lastName")]
        public string LastName;
        [XmlElement("addressStreet")]
        public string AddressStreet;
        [XmlElement("phone")]
        public string Phone;
        [XmlElement("addressZipcode")]
        public string AddressZipcode;
        [XmlElement("companyName")]
        public string CompanyName;

        public ProfileData(string firstName, string lastName, string addressStreet, string phone, string addressZipcode, string companyName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.AddressStreet = addressStreet;
            this.Phone = phone;
            this.AddressZipcode = addressZipcode;
            this.CompanyName = companyName;
        }

        public ProfileData()
        {
            
        }
    }
}