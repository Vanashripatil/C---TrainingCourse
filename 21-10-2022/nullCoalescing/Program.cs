using System;

class Program
{
  static void Main()
  {
     int? number = null;

     int availableTicket = number ?? 0;

     Console.WriteLine("AvailableTicket {0}", availableTicket);
  }
}