//C# Program to Check Whether a Given Number is Even or Odd
using System;

class Program
{
  static void Main()
  {
    Console.WriteLine("Enter the number");
    int number = int.Parse(Console.ReadLine());
    
    if(number % 2 == 0)
    {
      Console.WriteLine("Number {0} is Even", number);
    }
    else
    {
      Console.WriteLine("Number {0} is odd", number);
    }
  }
}