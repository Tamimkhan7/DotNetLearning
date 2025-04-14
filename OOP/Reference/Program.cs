// constructor is called, when method name and class name are same that's called the constructor

using System;

class Person
{
    public string name;
    public int age;


}
class Test
{

    public static void Main(string[] args)
    {
        Person p1 = new Person();
        p1.name = "Tamim khan";
        p1.age = 10;
        Console.WriteLine($" Before Refering P1 :- Name is {p1.name} and age is {p1.age} ");


        Person p2 = p1; // use p1 object ar references in the p2 object
        p2.name = "Hanna khan";
        p2.age = 70;
        Console.WriteLine($" P2 :- Name is {p2.name} and age is {p2.age} ");
        Console.WriteLine($" After Refering P1 :- Name is {p1.name} and age is {p1.age} ");


    }
}