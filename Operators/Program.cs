using System;
class Test {
   

  public static void Main(string[] args ){
     
    // Arithmetic operators

    int x = 10+20;
    Console.WriteLine(x);

    int sum = 100 + 50;
    Console.WriteLine(sum);

    x += 10;
    Console.WriteLine(x);

    x *=2;
    Console.WriteLine(x);
    x %= 10;
    Console.WriteLine(x);

    x++;
    Console.WriteLine(x);


    // Comparison operators

    int a = 10,b = 50;
    if(a==b)
    Console.WriteLine("True");
   else     
    Console.WriteLine("False");

     if(a<b)
    Console.WriteLine("True");
   else     
    Console.WriteLine("False");

  int n = Convert.ToInt32(Console.ReadLine());
  bool ok = true;
    
  for(int i=2;i*i<=n;i++){
    if(n%i==0){
      ok = false;
      break;
    }
  }
  
    if(ok)Console.WriteLine($"{n} is a Prime number");
    else Console.WriteLine($"{n} is not a Prime number");

  }
}
