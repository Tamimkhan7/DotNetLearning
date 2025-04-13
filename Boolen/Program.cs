
using System;
class Test {

  public static void Main(string[] args ){
       
       bool ok = false;
       Console.WriteLine(ok);

        int x = 10;
        int y = 9;
        Console.WriteLine(x > y);


        x = 10;
        Console.WriteLine(x == 10); 

        int my_age = 25;
        int voting_age = 18;
        Console.WriteLine(my_age>=voting_age);


        // if else condition
         x = 2;
         y = 18;
        if (x > y) 
        Console.WriteLine("x is greater than y");
        else  Console.WriteLine("x is less than y");


        int time = 20;
        string result = (time < 18) ? "Good day." : "Good evening.";
        Console.WriteLine(result);
  
    }
}
