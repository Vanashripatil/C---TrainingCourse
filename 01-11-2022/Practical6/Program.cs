// C# Program to Get a Number and Display the Number with its Reverse
using System;

class Program
{
  static void Main()
  {
    int num, rev = 0, rem;
    Console.WriteLine("Enter the number");
    num = int.Parse(Console.ReadLine());
    
    while(num !=0)
    {
      rem = num % 10;
      rev = rev * 10 + rem;
      num/=10;
    }
    Console.WriteLine(rev);
  }
}