using System;
using System.Xml;
using System.Xml.Serialization;

namespace AutoTest_One
{
    public static class Settings
    {
        private const string File = "Settings.xml";

        private static string _baseUrl;
        private static string _login;
        private static string _password;

        private static readonly XmlDocument Document;

        public static string BaseUrl
        {
            get
            {
                if (_baseUrl != null) return _baseUrl;
                var node = Document.DocumentElement?.SelectSingleNode("BaseUrl");
                _baseUrl = node?.InnerText;
                return _baseUrl;
            }
        }

        public static string Login
        {
            get
            {
                if (_login != null) return _login;
                var node = Document.DocumentElement?.SelectSingleNode("Login");
                _login = node?.InnerText;
                return _login;
            }
        }

        public static string Password
        {
            get
            {
                if (_password != null) return _password;
                var node = Document.DocumentElement?.SelectSingleNode("Password");
                _password = node?.InnerText;
                return _password;
            }
        }

        static Settings()
        {
            if (!System.IO.File.Exists(File))
            {
                throw new Exception("Problem: settings file not found: " + File);
            }
            Document = new XmlDocument();
            Document.Load(File);
        }
    }
}