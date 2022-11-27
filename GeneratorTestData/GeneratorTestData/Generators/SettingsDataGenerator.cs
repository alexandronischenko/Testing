using System.Xml.Serialization;
using GeneratorTestData.Classes;
using GeneratorTestData.Extensions;

namespace GeneratorTestData.Generators;

public class SettingsDataGenerator
{
    private const string Path = "profileData.xml";

    public static void Generate()
    {
        var profileData = new SettingsData(
            "alex12345",
            "qwerty1!",
            "https://swiftbook.ru/");
        
        
        var formatter = new XmlSerializer(typeof(SettingsData));
        using var fileStream = new FileStream(Path, FileMode.OpenOrCreate);
        formatter.Serialize(fileStream, profileData);
        Console.WriteLine("Settings data saved");
    }
}