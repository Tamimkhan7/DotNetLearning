using System;
class Person
{
    public string name;
    public int age;

    public void value(string name, int age)
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
    public void value(string fruite_name, string fruite_color)
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
        Person p1 = new Person();
        p1.value("Tamim khan", 20);
        p1.Display();

        Person p2 = new Person();
        p2.value("Hanna khan", 40);
        p2.Display();

        Fruite fru = new Fruite();
        fru.value("Apple", "Red");
        fru.DisplayFood(); //use method and print them
    }
}