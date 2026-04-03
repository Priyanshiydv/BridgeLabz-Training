using System;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

class EmailSchemaValidation
{
    static void Main()
    {
        // JSON Schema definition
        string schemaJson = @"{
          'type': 'object',
          'properties': {
            'name': { 'type': 'string' },
            'email': { 
                'type': 'string',
                'format': 'email'
            }
          },
          'required': ['name', 'email']
        }";

        // Sample JSON data (change email to test)
        string jsonData = @"{
            'name': 'Priyanshi',
            'email': 'priya123@gmail.com'
        }";

        // Load schema
        JSchema schema = JSchema.Parse(schemaJson);

        // Load JSON object
        JObject user = JObject.Parse(jsonData);

        // Validate
        bool isValid = user.IsValid(schema, out IList<string> errors);

        if (isValid)
        {
            Console.WriteLine("✅ Email is VALID according to JSON Schema");
        }
        else
        {
            Console.WriteLine("❌ Email is INVALID");
            Console.WriteLine("Errors:");

            for (int i = 0; i < errors.Count; i++)
            {
                Console.WriteLine(errors[i]);
            }
        }
    }
}
