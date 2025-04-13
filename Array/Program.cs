using System;
class Test {

  public static void Main(string[] args) {
       
      //  array declear korar jonno first of all datatype declear kora lage then size declear kora lage then variable declear kora lage
      string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};

      for(int i=0;i<(int)cars.Length;i++)Console.WriteLine(cars[i]);
      Console.WriteLine();
      // change the array element
      cars[0] = "Opel";
      // now print the array element
      for(int i=0;i<(int)cars.Length;i++)Console.WriteLine(cars[i]);
       Console.WriteLine();

      int[] myNum = {10, 20, 30, 40};
      for(int i=0;i<(int)myNum.Length;i++)Console.WriteLine(myNum[i]);
      Console.WriteLine();

// others way string array declear
   
      string[] carss = new string[] {"Volvo", "BMW", "Ford"};
      for(int i=0;i<(int)carss.Length;i++)Console.WriteLine(carss[i]);
  }
}
