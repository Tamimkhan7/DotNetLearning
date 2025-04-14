using System;

class Test
{
    static void Mymethod()
    {
        Console.WriteLine("Calling my method");
    }

    static void passingmethod(string s)
    {
        Console.WriteLine(s);
    }

    static void multiplepass(string name, int age, string universityName)
    {
        Console.WriteLine($"My name is {name}, age is {age} and my university name is {universityName}, i'm study here already 4 yeras. ");
    }

    static void defaultparameter(string name = "Tamim khan")
    {
        Console.WriteLine(name);
    }

    static int factorial(int n)
    {
        int fact = 1;
        for (int i = 1; i <= n; i++) fact *= i;
        return fact;
    }


    static void Named_Arguments(string child1, string child2, string child3)
    {
        Console.WriteLine("The youngest child is: " + child3);
    }

    public static void Main(string[] args)
    {
        Mymethod();

        // method pass parameter
        passingmethod("Tamim khan");

        // multiple passing parameter 
        multiplepass("Tamim khan", 24, "Prime university");

        defaultparameter("Mannan khan");
        defaultparameter();

        int fact = factorial(5);
        Console.WriteLine(fact);

        Named_Arguments(child1: "hamim", child2: "khata", child3: "Bala");

    }
}
