using System;

class Program
{
  static void Main(string[] args)
  {
    string filePath = @"E:\Semester\Sadik 6th Sem\NetCentric.Vedas2080\Assignment 3\Inflation.csv";
    InflationAnalysis analysis = new InflationAnalysis();

    // Read CSV file
    analysis.ReadCsv(filePath);

    // Print the data to verify
    foreach (var inflation in analysis.Inflations)
    {
      Console.WriteLine($"Regional Member: {inflation.RegionalMember}, Year: {inflation.Year}, Inflation: {inflation.InflationRate}%, Unit: {inflation.UnitOfMeasurement}, Subregion: {inflation.Subregion}, Country Code: {inflation.CountryCode}");
    }

    //a
    // Find inflation rates for countries for the year 2021
    // var inflation2021 = analysis.Inflations.Where(i => i.Year == 2021).ToList();

    // Console.WriteLine("Inflation rates for countries in 2021:");
    // inflation2021.ForEach(i => Console.WriteLine($"{i.RegionalMember}: {i.InflationRate}%"));

    //b
    // Find the year when Nepal had the highest inflation
        // var nepalInflation = analysis.Inflations
        //     .Where(i => i.RegionalMember == "Nepal")
        //     .OrderByDescending(i => i.InflationRate)
        //     .FirstOrDefault();

        // if (nepalInflation != null)
        // {
        //     Console.WriteLine($"Nepal had the highest inflation rate of {nepalInflation.InflationRate}% in the year {nepalInflation.Year}.");
        // }
        // else
        // {
        //     Console.WriteLine("No data available for Nepal.");
        // }

      //c
      // Group by RegionalMember (country) and calculate average inflation rates
      //  var top10Countries = analysis.Inflations
      //       .GroupBy(i => i.RegionalMember)
      //       .Select(g => new
      //       {
      //           Country = g.Key,
      //           MaxInflation = g.Max(i => i.InflationRate)
      //       })
      //       .OrderByDescending(g => g.MaxInflation)
      //       .Take(10)
      //       .ToList();

      //   // Print the top 10 countries with highest inflation rates
      //   Console.WriteLine("Top 10 regions (countries) with highest inflation rates:");
      //   foreach (var item in top10Countries)
      //   {
      //       Console.WriteLine($"{item.Country}: Maximum Inflation Rate = {item.MaxInflation}%");
      //   }

      //d
        // Find the top 3 South Asian countries with lowest inflation rates for 2020
        // var top3Countries = analysis.Inflations
        //     .Where(i => i.Subregion == "South Asia" && i.Year == 2020)
        //     .OrderBy(i => i.InflationRate)
        //     .Take(3)
        //     .ToList();

        // // Print the top 3 countries with lowest inflation rates
        // Console.WriteLine("Top 3 South Asian countries with lowest inflation rates for 2020:");
        // foreach (var item in top3Countries)
        // {
        //     Console.WriteLine($"{item.RegionalMember}: Inflation Rate = {item.InflationRate}%");
        // }
  }
}



