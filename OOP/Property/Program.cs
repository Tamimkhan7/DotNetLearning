
using System;

class Person
{
    private string name;
    private int age;


    // public string Name
    // {
    //     get
    //     {
    //         return name;
    //     }
    //     set
    //     {
    //         name = value;
    //     }
    // }
    // it also be work here, if don't change anything then we will use it 
    public string Name
    {
        get;
        set;
    }
    // public int Age
    // {
    //     get
    //     {
    //         return age;
    //     }
    //     set
    //     {
    //         age = value; //value is a special keyword of the set property
    //     }
    // }
    // it also be work here 
    public int Age
    {
        get;
        set;
    }



}
class Test
{

    public static void Main(string[] args)
    {
        Person p1 = new Person();
        p1.Name = "Tamim khan";
        p1.Age = 10;
        Console.WriteLine($" P1 :- Name is {p1.Name} and age is {p1.Age} ");
    }
}