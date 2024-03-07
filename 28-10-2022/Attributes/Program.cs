using System;

class Program
{
  static void Main()
  {
    Calculator.Add(10, 20);
  }
}

public class Calculator
{
  [ObsoleteAttribute("Use Add(List<int> Numbers Method")]
   public static int Add(int firstNumber, int secondNumber)
   {
    return firstNumber + secondNumber;
   }

   public static int Add(List<int> Numbers)
   {
    int sum = 0;
    foreach (int Number in Numbers)
    {
      sum = sum + Number;
    }
   }
}