using System;
class Test {    
  public static void Main(string[] args ){
     
// Strings are used for storing text.
// A string variable contains a collection of characters surrounded by double quotes:

  string greeting = "hello world";
    Console.WriteLine(greeting);

string greeting2 = "Nice to meet you!";
    Console.WriteLine(greeting2);


//how to find string lenth from the given string

string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
// both function are working here
  int length = Convert.ToInt32(txt.Length);
  // int length = (int)(txt.Length);
    Console.WriteLine($"length of the string {length}");


    string ss = txt.ToLower(); //convert into uppercase to lowercase
    Console.WriteLine(ss);


    ss = txt.ToUpper(); //convert into lowercase to uppercase
    Console.WriteLine(ss);


    // concatenation

  string firstName = "Tamim", lastName = "khan";
  string fullName = firstName + " " + lastName;
  string fullName2 =string.Concat( firstName + " " + lastName);
// both are working fine, we can use any of them
    Console.WriteLine(fullName);
    Console.WriteLine(fullName2);
    }
}
