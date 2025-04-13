using System;
using System.Linq;
class Test
{

  public static void Main(string[] args)
  {

    //  array declear korar jonno first of all datatype declear kora lage then size declear kora lage then variable declear kora lage
    string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

    for (int i = 0; i < (int)cars.Length; i++) Console.WriteLine(cars[i]);
    Console.WriteLine();
    // change the array element
    cars[0] = "Opel";
    // now print the array element
    for (int i = 0; i < (int)cars.Length; i++) Console.WriteLine(cars[i]);
    Console.WriteLine();

    int[] myNum = { 10, 20, 30, 40 };
    for (int i = 0; i < (int)myNum.Length; i++) Console.WriteLine(myNum[i]);
    Console.WriteLine();

    // others way string array declear

    string[] carss = new string[] { "Volvo", "BMW", "Ford" };
    for (int i = 0; i < (int)carss.Length; i++) Console.WriteLine(carss[i]);
    Console.WriteLine();

    string[] garis = { "Volvo", "BMW", "Ford", "Mazda" };

    foreach (string gari in garis)
      Console.WriteLine(gari);

    // string array sort
    Console.WriteLine();
    Array.Sort(garis);

    foreach (string gari in garis)
      Console.WriteLine(gari);

    // int n = Convert.ToInt32(Console.ReadLine());
    // int[] array = new int[n];
    // for (int i = 0; i < n; i++)
    // {
    //   int x = Convert.ToInt32(Console.ReadLine());
    //   array[i] = x;
    // }
    // Array.Sort(array);

    // foreach (int arr in array) Console.WriteLine(arr);

    int[] myNumbers = { 5, 1, 8, 9 };
    Console.WriteLine(myNumbers.Max());
    Console.WriteLine(myNumbers.Min());
    Console.WriteLine(myNumbers.Sum());

    int x = 10, y = 20;
    int mx = Math.Min(x, y);
    Console.WriteLine(mx);
    Console.WriteLine();



    // multidimensional array
    // Good to know: The single comma[,] specifies that the array is two - dimensional.A three - dimensional array would have two commas: int[,,].
    // Remember that: Array indexes start with 0: [0] is the first element. [1] is the second element, etc.
    int[,] number = { { 1, 4, 2 }, { 1, 8, 5 } };
    number[0, 0] = 5;  // Change value to 5 into the (0,0) index
                       // Console.WriteLine(number[1, 1]);
                       // print of the 2d array using foreach loop 
    foreach (int val in number) Console.Write($"{val} ");
    Console.WriteLine();


    for (int i = 0; i < number.GetLength(0); i++)
    {
      for (int j = 0; j < number.GetLength(1); j++)
        Console.Write($"{number[i, j]} ");
    }
    Console.WriteLine();

  }
}
