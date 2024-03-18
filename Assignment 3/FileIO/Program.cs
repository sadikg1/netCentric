string filePath = @"E:\Semester\Sadik 6th Sem\NetCentric.Vedas2080\Assignment 3\Inflation.csv";

// Instantiate the Inflation class
Inflation inflation = new Inflation();

// Call the method to read the CSV file and create properties dynamically
inflation.SetPropertiesFromCSV(filePath);
inflation.PrintProperties();
Console.WriteLine("Successfully created properties");
