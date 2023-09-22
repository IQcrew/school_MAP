using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace virtual_MAP_windows
{
    public static class dataManager
    {
        public static string constantPath = @"src\rooms";
        public static string jsonFilePath = @$"{constantPath}\data.json";
        public static Dictionary<string, Dictionary<string, string>> data = new Dictionary<string, Dictionary<string, string>>();

        public static void innit()
        {
            if (File.Exists(jsonFilePath))
            {
                // Read the JSON data from the file
                string jsonString = File.ReadAllText(jsonFilePath);

                // Deserialize the JSON data into a dictionary of dictionaries
                data = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(jsonString);
            }
            else 
            {
                string jsonString = JsonSerializer.Serialize(data, new JsonSerializerOptions
                {
                    WriteIndented = true // For pretty-printing the JSON
                });

                // Write the JSON string to a file
                File.WriteAllText(jsonFilePath, jsonString);
            }
        }

        public static void writeData()
        {
            string jsonString = JsonSerializer.Serialize(data, new JsonSerializerOptions
            {
                WriteIndented = true // For pretty-printing the JSON
            });

            // Write the JSON string to a file
            File.WriteAllText(jsonFilePath, jsonString);
        }

    }
}
