using System;
using Newtonsoft.Json;
using System.Xml;

class JsonToXml
{
    static void Main()
    {
        // Sample JSON
        string json = @"{
            'student': {
                'name': 'Rahul',
                'age': 23,
                'course': 'Computer Science'
            }
        }";

        // Convert JSON to XML
        XmlDocument doc = JsonConvert.DeserializeXmlNode(json, "Root");

        // Display XML
        Console.WriteLine("Converted XML:\n");
        Console.WriteLine(doc.OuterXml);
    }
}
