using System;
class Helpers{
     void Print(){
        Console.WriteLine("hELLO");
     }
     void Print(string greeting){//method overloading
        Console.WriteLine(greeting);
     }
     float CalculateBMI(float heightInft,float weightInkg){
        float heightInM=heightInft/3.14f;
        float bmi= weightInkg/(heightInM*heightInM);//kg/m^2
        return bmi;
     }
}