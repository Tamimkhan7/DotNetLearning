using System;
class Test {

  public static void Main(string[] args) {
       

      //  auto didn't work c#, that's why ignore it
    // While Loop
    int i = 0;
    while (i <= 10) {
      Console.WriteLine(i);
      i++;
    }

    // Do While Loop
    i = 0;
    do {
      Console.Write($"{i} ");
      i++;
    } while (i <= 100);
    Console.WriteLine(); // Optional: for newline after the do-while output

    // For Loop
    Console.WriteLine("for loop");
    for (i = 0; i < 5; i++) {
      Console.WriteLine(i);
    }

    // Foreach Loop
    string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
    foreach (string car in cars)
      Console.WriteLine(car);


      // break and continue

      for ( i = 0; i < 10; i++) 
      {
        if (i == 4)    
          continue;
          else if(i>7)break;
     
        Console.WriteLine(i);
      }
  }
}
