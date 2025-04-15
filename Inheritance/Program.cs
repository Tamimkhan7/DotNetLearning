using System;

class vehicle
{
    public string brand = "Ford";
    public void honk()
    {
        Console.WriteLine("Tuut, Tuuti");
    }
}


class car : vehicle
{
    public string modelName = "Mustang";
}


class Test
{
    public static void Main(string[] args)
    {
        car mycar = new car();
        mycar.honk();
        Console.WriteLine(mycar.brand + " " + mycar.modelName);
    }
}
