// constructor is called, when method name and class name are same that's called the constructor

using System;

class Person
{
    public string name;
    public int age;

    // we can create default constructor

    public Person()
    {
        name = "ABC";
        age = 0;
    }

    //this person function name is contructor, because method function name and class function are same
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }


    public void Display()
    {
        Console.WriteLine(name);
        Console.WriteLine(age);
    }

}
class Fruite
{
    public string fruite_name, fruite_color;

    // this is another constructor
    public Fruite(string fruite_name, string fruite_color)
    {
        this.fruite_name = fruite_name;
        this.fruite_color = fruite_color;
    }
    public void DisplayFood()
    {
        Console.WriteLine(fruite_name);
        Console.WriteLine(fruite_color);
    }
}
class Test
{

    public static void Main(string[] args)
    {
        Person p1 = new Person("Tamim khan", 20);
        p1.Display();

        Person p2 = new Person("Hanna khan", 40);
        p2.Display();

        Person p3 = new Person();
        p3.Display();

        Fruite fru = new Fruite("Apple", "Red");
        fru.DisplayFood(); //use method and print them
    }
}