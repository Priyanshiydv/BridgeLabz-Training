using System;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

class ValidateJson
{
    static void Main()
    {
        // Read JSON and schema files
        string jsonData = File.ReadAllText("student.json");
        string schemaData = File.ReadAllText("studentSchema.json");

        // Parse JSON and Schema
        JToken json = JToken.Parse(jsonData);
        JSchema schema = JSchema.Parse(schemaData);

        // Validate JSON against schema
        bool isValid = json.IsValid(schema, out IList<string> errors);

        if (isValid)
        {
            Console.WriteLine("JSON is valid according to schema ✅");
        }
        else
        {
            Console.WriteLine("JSON is invalid ❌");
            Console.WriteLine("Errors:");
            foreach (var err in errors)
            {
                Console.WriteLine("- " + err);
            }
        }
    }
}
