using System;

class Program
{
  static void Main()
  {
    TimeZone zone = TimeZone.CurrentTimeZone;
    DateTime local = zone.ToLocalTime(DateTime.Now);
    Console.WriteLine("The Local Time is : {0}",local);
    Console.ReadLine();
  }
}