using System;
class Test {
    // user input always provided string value

  public static void Main(string[] args ){
     
    // using for get input from user
     string student_name = Console.ReadLine();
    //  Console.WriteLine("Student Name: "+  student_name);
      Console.WriteLine($"Student Name :- {student_name}");
      int age = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("My Age is :- "+ age);
    }
}
