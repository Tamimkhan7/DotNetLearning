// constructor is called, when method name and class name are same that's called the constructor

using System;

class Person
{
    public string name;
    private int age;

    public void setvalue(int age) //just writeable function not readable
    {
        this.age = age;
    }

    public int getvalue() // just readable function don't write anything
    {
        return age;
    }


}
class Test
{

    public static void Main(string[] args)
    {
        Person p1 = new Person();
        p1.name = "Tamim khan";
        p1.setvalue(10);
        Console.WriteLine($" P1 :- Name is {p1.name} and age is {p1.getvalue()} ");
    }
}