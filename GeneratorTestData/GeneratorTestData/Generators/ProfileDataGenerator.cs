using System.Xml.Serialization;
using GeneratorTestData.Classes;
using GeneratorTestData.Extensions;

namespace GeneratorTestData.Generators;

public static class ProfileDataGenerator
{
    private const string Path = "ProfileData.xml";

    public static void Generate(int count)
    {
        var data = new List<ProfileData>();
        for (var i = 0; i < count - 1; i++)
        {
            var profileData = new ProfileData(
                StringExtension.RandomString(8),
                StringExtension.RandomString(8),
                StringExtension.RandomString(8),
                StringExtension.RandomString(8),
                StringExtension.RandomString(8),
                StringExtension.RandomString(8));
            data.Add(profileData);
        }

        var formatter = new XmlSerializer(typeof(List<ProfileData>));
        using var fs = new FileStream(Path, FileMode.OpenOrCreate);
        formatter.Serialize(fs, data);
        Console.WriteLine("Settings data saved");
    }
}