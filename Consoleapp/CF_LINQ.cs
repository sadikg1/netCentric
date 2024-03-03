//LINQ-LAnguage INtegrated Query
using System.Linq;
class LINQLearner{
    public void Learn()
    {
        int[] numbers=[3,4,5,65,67,7];
        List <Student> students=
        [
            new Student("Ram Thapa",10,"ram@gmail.com"),
            new Student("Rama Thing",111,"rama@abc.com"),
            new Student("Rajesh Stha",23,"rajesh@gmail.com"),
            new Student("Tirtha Pokhrel",1,"tirtha@yahoo.com"),
            new Student("Tika Yadav",5,"tika@live.com"),
        ];
        var squareNUmbers=numbers.Select(x=>x*x);//select
        var evenNUmbers=numbers.Where(x=> x%2 == 0);//lamda expression

        //Find cubes of all odd numbers with in "Numbers"
        var cubeOddNumbers=numbers.Where(x=>x%2==1).Select(x=>Math.Pow(x,3));
        //Expression Syntax
        cubeOddNumbers=from  num in numbers where num%2==1 select Math.Pow(num,3);
                        

        //Find student with roll number less tahn 50 and orderby Name them in ascending oredr
        var verifiedStudents =students.Where(students=>students.rollNumber<50).OrderBy(student => student.Name);


        //Group all students by email domain
        var studentGroups=students.GroupBy(student=>student.Email[(student.Email.IndexOf('@')+1)..]);
        // var studentGroups = students.GroupBy(student => student.Email.Substring(student.Email.IndexOf('@') + 1)..);

        foreach(var studentGroup in studentGroups)
        {
            Console.WriteLine($"Domain Name: {studentGroup.Key}");
            foreach(var student in studentGroup)
            {
                Console.WriteLine($"\t\t{student.PrintInfo()}");

            }
        }

    }
}
