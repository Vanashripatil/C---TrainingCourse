using System;

class Program
{
  static void Main()
  {
    int OutSider = 20;
    Somefunction(ref OutSider);

    Console.WriteLine(OutSider);
  }

  static void Somefunction(ref int InSider)
  {
    InSider = InSider + 10;
  }
}