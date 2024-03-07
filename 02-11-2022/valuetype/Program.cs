using System;

class Program
{
  static void ChangeValue(int i)
  {
    i = 200;
    Console.WriteLine(i);
  }
  static void Main()
  {
    int i = 100;
    Console.WriteLine(i);

    ChangeValue(i);
    Console.WriteLine(i);
  
  }
}