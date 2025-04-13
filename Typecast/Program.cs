using System;
class TypeCast{
    public static void Main(string [] args){
        double gpa = 3.9;
        Console.WriteLine((int)gpa);

        bool ok = false;
        Console.WriteLine(Convert.ToString(ok));

        int val = 105;
         Console.WriteLine(Convert.ToString(val));

         string s = "120";
        Console.WriteLine(Convert.ToInt32(val));
         char c = 'a';
         int print = (int)c; //print ASCII value of the character 
        Console.WriteLine(print);

        //is called nameing print
        Console.WriteLine($"My character is = {c}");

        // we can use Parse or TryParse method for change the string value into the integer 
    }
}