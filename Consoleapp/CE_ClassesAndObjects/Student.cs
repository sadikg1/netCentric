using System;
class Student
{
    //Default
    public Student(){

    }
    public Student(string n, byte rn, string e){
        name=n;
        rollNumber=rn;
        Email=e;

    }
    public Student(string n, byte rn, string e,DateTime dob):this(n,rn,e)
    {
        Dob=dob;

    }
    string name;
    //Full property Definition
    //this is property> requires Pascal Casing
    public string Name{
        get{
            return name;
        }
        set{
            if(value.Length>=2){
                name=value;   
            }
        }
    }
    public byte rollNumber;
    //Readonly property
    public DateTime Dob{get;}

    //Auto implemented property
    public string Email{get; set;}

    public virtual string  PrintInfo(){
        var studentInfo=$"Student Name:{Name}, Roll Number:{rollNumber}, Dob:{Dob}, Email:{Email}";
        return studentInfo;
    }


}