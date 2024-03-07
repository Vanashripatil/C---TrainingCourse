using System;

class Program
{
  static void Main()
  {
    Console.WriteLine("Enter the first Name");
    string firstName = Console.ReadLine();

    Console.WriteLine("Enter the last Name");
    string lastName = Console.ReadLine();

    Console.WriteLine("Hello {0}, {1}", firstName, lastName);
  }
}
