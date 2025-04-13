using System;
class Test {    
  public static void Main(string[] args ){
     
      int a=10, b=50;
    //   Max value between two variable
    int mx = Math.Max(a,b);
    Console.WriteLine($"Max value is {mx}");


    //   Min value between two variable
    int mn = Math.Min(a,b);
    Console.WriteLine($"Min value is {mn}");

    int x = 90;
     //sqrt value of the x variable
    int square_value = Convert.ToInt32(Math.Sqrt(x)); //sqrt function return the double value,  
    Console.WriteLine($"square value is {square_value}");

    //   abs function return the positive value
    x = -20;
    int positive = Math.Abs(x);
    Console.WriteLine($"The value is {positive}");

    // round function always return the round value 
    double val = 9.6;
      int round_value = Convert.ToInt32(Math.Round(val));
    Console.WriteLine($"The round_value is {round_value}");
    }
}

// point ar por koto ghor print korbo seta amra bole dite pari ai vabe
// div.ToString("F2"); F2 means 2 ghor rakhbo