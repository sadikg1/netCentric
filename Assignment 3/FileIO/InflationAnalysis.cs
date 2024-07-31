using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

public class InflationAnalysis
{
    public List<Inflation> Inflations { get; set; } = new List<Inflation>();

    // Method to read CSV file and populate the list
    public void ReadCsv(string filePath)
    {
        var lines = File.ReadAllLines(filePath);
        foreach (var line in lines.Skip(1)) // Skip header
        {
            var values = ParseCsvLine(line);

            // Ensure we have the correct number of columns
            if (values.Length < 6)
            {
                continue;
            }

            try
            {
                var inflation = new Inflation
                {
                    RegionalMember = values[0].Trim(),
                    Year = int.Parse(values[1].Trim()),
                    InflationRate = string.IsNullOrWhiteSpace(values[2]) ? 0 : double.Parse(values[2].Trim(), CultureInfo.InvariantCulture),
                    UnitOfMeasurement = values[3].Trim(),
                    Subregion = values[4].Trim(),
                    CountryCode = values[5].Trim()
                };

                Inflations.Add(inflation);
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error parsing line: {line}. Exception: {ex.Message}");
            }
        }
    }

    // Helper method to parse CSV line considering quoted fields
    private string[] ParseCsvLine(string line)
    {
        var values = new List<string>();
        bool inQuotes = false;
        string value = "";

        foreach (var c in line)
        {
            if (c == '"' && !inQuotes)
            {
                inQuotes = true;
                continue;
            }

            if (c == '"' && inQuotes)
            {
                inQuotes = false;
                continue;
            }

            if (c == ',' && !inQuotes)
            {
                values.Add(value);
                value = "";
                continue;
            }

            value += c;
        }

        values.Add(value);

        return values.ToArray();
    }
}
