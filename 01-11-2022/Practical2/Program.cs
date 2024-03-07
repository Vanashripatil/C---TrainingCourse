using System;

class Program
{
  static void Main()
  {
   Console.WriteLine("Enter the first number");
   int num1 = int.Parse(Console.ReadLine());

   Console.WriteLine("Enter the second number");
   int num2 = int.Parse(Console.ReadLine());

   int temp;
   temp = num2;
   num1 = num2;
   num1 = temp;

   Console.WriteLine("Swapped number num1 {0} & num2 {1}", num1, num2);
  }
}