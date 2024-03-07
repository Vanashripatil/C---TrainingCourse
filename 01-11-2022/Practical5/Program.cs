//C# Program to Find Sum of Digits of a Number using Recursion
using System;

class Program
{
  static void Main()
  {
    int num;
    Calculator C1 = new Calculator();
    Console.WriteLine("Enter the number");
    num = int.Parse(Console.ReadLine());
    int result = C1.sum(num);
    Console.WriteLine(result);
  }
}

class Calculator
{
  public int sum(int num)
  {
    if(num != 0)
    {
      return (num % 10 + sum(num / 10));
    }
    else
    {
      return 0;
    }
  }
}