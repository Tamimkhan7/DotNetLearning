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


    // adding a two string
    string x = "10", y = "20";
    string ans = x+y;
    Console.WriteLine(ans);

// string interpolation

    firstName = "John";
   lastName = "Doe";

  string name = $"My full name is : {firstName} {lastName}";
  Console.WriteLine(name);

  // access string 
  string myString = "Hello";
  Console.WriteLine(myString[4]);

  // You can also find the index position of a specific character in a string, by using the IndexOf() method:
   myString = "Hello";
  // given e index position into the hello word
  Console.WriteLine(myString.IndexOf("e"));


// find substring in the name string
       name = "John Doe";
      
    // startpoint and ending post we will be mention here
     string substr = name.Substring(0, 3);
    Console.WriteLine(substr);

// The sequence \'  inserts a single quote in a string:
    txt = "It\'s alright.";
    Console.WriteLine(txt);

// The sequence \\  inserts a single backslash in a string:
    txt = "The character \\ is called backslash.";
        Console.WriteLine(txt);


    }
}
