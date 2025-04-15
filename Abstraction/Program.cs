using System;

abstract class Animal
{
    // Abstract method (does not have a body)
    public abstract void animalSound();

    // Regular method
    public void sleep()
    {
        Console.WriteLine("Zzz");
    }
}


// Derived class (inherit from Animal)
class Pig : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The pig says: wee wee");
    }
}

class Test
{
    public static void Main(string[] args)
    {
        Pig mypig = new Pig();
        mypig.animalSound();
        mypig.sleep();
    }
}
