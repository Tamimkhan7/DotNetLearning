
using System;


class Test
{

    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the calculator App");

        try
        {
            Console.Write("Enter num1  = ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter num2  = ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int res = num1 / num2;
            Console.Write($"Result is :- {res}");
        }
        // find exception message
        catch (Exception e)
        {
            Console.WriteLine($"Exception is :- {e.Message}");
        }

        finally
        {
            // finally function ar modde jai thakbe oita kaj korbe normally, onno jaygay jodi oh wrong ba somossa dey tahole oh aita kono somossa hobe na
            Console.WriteLine($"Goodbye!!!!");
        }
    }
}