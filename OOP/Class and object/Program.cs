using System;
class Person
{
    public string name;
    public int age;

}
// i also created another for storing cars property class
class Fruite
{
    public string fruite_name, fruite_color;

}
class Test
{

    public static void Main(string[] args)
    {
        Person p1 = new Person();
        p1.name = "Tamim khan";
        p1.age = 20;
        Console.WriteLine(p1.name);
        Console.WriteLine(p1.age);

        Person p2 = new Person();
        p2.name = "Hanna khan";
        p2.age = 40;
        Console.WriteLine(p2.name);
        Console.WriteLine(p2.age);

        Fruite fru = new Fruite();
        fru.fruite_name = "Apple";
        fru.fruite_color = "Red";
        Console.WriteLine(fru.fruite_name);
        Console.WriteLine(fru.fruite_color);


    }
}

