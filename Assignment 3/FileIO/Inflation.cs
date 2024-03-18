using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

public class Inflation{
    // Dictionary to store properties and their values
    private Dictionary<string, object> properties = new Dictionary<string, object>();

    // Method to read the CSV file and set properties dynamically
    public void SetPropertiesFromCSV(string filePath)
    {
        // Check if the file exists
        if (File.Exists(filePath))
        {
            // Read all lines from the CSV file
            string[] lines = File.ReadAllLines(filePath);

            // Check if the file contains any data
            if (lines.Length > 0)
            {
                // Split the first line to get column headers
                string[] headers = lines[0].Split(',');

                // Iterate through each line starting from the second line (data rows)
                for (int i = 1; i < lines.Length; i++)
                {
                    // Split the current line to get data values
                    string[] values = lines[i].Split(',');

                    // Assign values to properties dynamically
                    for (int j = 0; j < values.Length && j < headers.Length; j++)
                    {
                        SetProperty(headers[j], values[j]);
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("File not found!");
        }
    }

    // Helper method to set a property by name
    private void SetProperty(string propertyName, string value)
    {
        // Convert the value to the appropriate type
        if (double.TryParse(value, out double doubleValue))
        {
            properties[propertyName] = doubleValue;
        }
        else
        {
            properties[propertyName] = value;
        }
    }

    // Method to get the value of a property by name
    // public object GetProperty(string propertyName)
    // {
    //     if (properties.ContainsKey(propertyName))
    //     {
    //         return properties[propertyName];
    //     }
    //     else
    //     {
    //         return null;
    //     }
    // }
    public void PrintProperties()
    {
        foreach (var property in properties)
        {
            Console.WriteLine($"{property.Key}: {property.Value}");
        }
    }

}