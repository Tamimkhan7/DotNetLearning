using System;

class Animal
{
    public virtual void animalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

class Pig : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The Pig says: wee wee");
    }
}

class Dog : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The Dog says: bow wow");
    }
}


class Test
{
    public static void Main(string[] args)
    {
        Animal myanimal = new Animal();
        Animal mypig = new Pig();
        Animal mydog = new Dog();

        myanimal.animalSound();
        mypig.animalSound();
        mydog.animalSound();
    }
}
