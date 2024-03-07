using System;

class Program
{
  static void Main()
  {
    Random r1 = new Random();
    for(int i=1;i<4;i++)
    {
      Console.WriteLine(r1.next());
    }
  }
}