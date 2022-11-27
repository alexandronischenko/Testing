using System.Xml.Serialization;

namespace GeneratorTestData.Classes;

public class SettingsData
{
    [XmlElement("login")] public string Login { get; set; }
    [XmlElement("password")] public string Password { get; set; }
    [XmlElement("url")] public string Url { get; set; }

    public SettingsData(string login, string password, string url)
    {
        Login = login;
        Password = password;
        Url = url;
    }
}