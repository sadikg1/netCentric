// See https://aka.ms/new-console-template for more information
// Console.Write("Enter the full name: ");
//Write keeps in sam eplace WriteLIne takes input from next line
// string fullName= Console.ReadLine(); 
//dob
DateTime dob=default;
var parsingSuccess=false;

while(!parsingSuccess){
    Console.Write("Your DOB (yyyy/mm/dd): ");
    string dobString = Console.ReadLine();
    parsingSuccess= DateTime.TryParse(dobString, out dob);
    
}
var ageOutput=CalculateAge(dob);
Console.WriteLine(ageOutput);



string CalculateAge(DateTime dob){
    // Calculate the age
    TimeSpan difference = DateTime.Now - dob;
    var days = difference.TotalDays;

    var years = (int)(days / 365);
    var remainingDays = days % 365;
    var months =(int)(remainingDays / 30);
    var remainingDaysInMonth = (int)(remainingDays % 30);

    var output =$"Your age is: {years} years, {months} months, and {remainingDaysInMonth} days.";
    return output;


}


// string cFullName=fullName.ToUpper();
// // or Console.WriteLine(fullName+"/n"+cFullName);
// Console.WriteLine($"Name: {fullName} Capital Name: {cFullName}");


