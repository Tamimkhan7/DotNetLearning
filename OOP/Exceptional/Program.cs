using System;

class Test
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the calculator App");

        try
        {
            int num1 = ReadIntegerInput("num1");
            int num2 = ReadIntegerInput("num2");

            if (num2 > 1000)
                throw new ArgumentException("Num2 can't be greater than 1000");

            int res = num1 / num2;
            Console.WriteLine($"Result is :- {res}");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine($"Input can't be null or empty");
        }
        // catch (OverflowException)
        // {
        //     Console.WriteLine($"Number was too big or small for Int32");
        // }
        // catch (FormatException)
        // {
        //     Console.WriteLine($"Invalid Input! Please enter a valid integer");
        // }
        // catch (DivideByZeroException)
        // {
        //     Console.WriteLine($"Cannot divide by zero");
        // }
        // catch (Exception e)
        // {
        //     Console.WriteLine($"Exception is :- {e.Message}");
        // }
        finally
        {
            Console.WriteLine($"Goodbye!!!!");
        }

        static int ReadIntegerInput(string prompt)
        {
            while (true)
            {
                Console.Write($"Enter {prompt} = ");
                string input = Console.ReadLine() ?? "";
                if (string.IsNullOrEmpty(input) || !int.TryParse(input, out int result))
                {
                    Console.WriteLine($"Invalid Input! Please enter a valid integer.");
                    continue;
                }
                return result;
            }
        }
    }
}
