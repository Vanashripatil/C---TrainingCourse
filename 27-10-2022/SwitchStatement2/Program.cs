using System;

class Program
{
  static void Main()
  {
    Console.WriteLine("Enter the number");
    int username = int.Parse(Console.ReadLine());
    
    switch (username)
    {
      case 10:
      case 20:
      case 30:Console.WriteLine("number is {0}", username);
              break;
      default:Console.WriteLine("number are not 10, 20 or 30");
              break;
    }
  }
}