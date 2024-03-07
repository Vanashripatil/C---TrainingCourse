//C# Program to Generate Fibonacci Series
using System;

class Program
{
  static void Main()
  {
    int num1=0, num2=1;
    int num3;
    Console.WriteLine("Enter the number");
    int num = int.Parse(Console.ReadLine());
    
    Console.WriteLine(num1.ToString(), num2.ToString());
    for(int i = 0;i < num;i++)
    {
      num3 = num1 + num2;
      Console.WriteLine(num3.ToString());
      num1 = num2;
      num2 = num3;
    }
    
  }
}