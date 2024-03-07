using System;

class Program
{
  static void Main()
  {
    int? i = null;

    bool? areYouMajor = null;
    if(areYouMajor == true)
    {
      Console.WriteLine("user is major");
    }
    else if(areYouMajor == false)
    {
      Console.WriteLine("user is not major");
    }
    else
    {
      Console.WriteLine("Not applicable");
    }
  }
}