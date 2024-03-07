//C# Program to Print Odd Numbers in a Given Range
using System;

class Program
{
  static void Main()
  {
    Console.WriteLine("Print all number from 1 to 100");
    for(int i = 1; i<=100; i++)
    {
      if(i % 2 != 0)
      {
        Console.WriteLine(i);
      }
    }
  }
}