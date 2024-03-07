//C# Program to Print All the Multiples of 17 which are Less than 100
using System;

class Program
{
  static void Main()
  {
    Console.WriteLine("print all number multiple of 17 and less than 100");
    for(int i = 1;i<100;i++)
    {
      if(i % 17 == 0)
      {
        Console.WriteLine(i);
      }
    }
  }
}