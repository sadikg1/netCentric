Console.Write("Enter the full name: ");
string fullName= Console.ReadLine(); 
string cFullName=fullName.ToUpper();
Console.Write("Your DOB (yyyy/mm/dd): ");
DateTime.TryParse(Console.ReadLine(), out DateTime dob);
var ageOutput=CalculateAge(dob);
Console.WriteLine($"Hello, {cFullName} Ji! \nYour DOB: {dob.ToLongDateString()} \n{ageOutput}");
string CalculateAge(DateTime dob){
    // Calculate the age
    TimeSpan difference = DateTime.Now - dob;
    var days = difference.TotalDays;

    var years = (int)(days / 365);
    var remainingDays = days % 365;
    var months =(int)(remainingDays / 30);
   
    var remainingDaysInMonth = (int)(remainingDays % 30);
    var weeks=(int)(remainingDaysInMonth/7);
    var remainingDaysInWeek=(int)(remainingDaysInMonth%7);

    var output =$"Age as of now: {years} years, {months} months, {weeks} weeks and {remainingDaysInMonth} days.";
    return output;
}
