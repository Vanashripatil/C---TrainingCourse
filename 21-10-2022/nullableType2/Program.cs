using System;

class Program
{
  static void Main()
  {
      int? ticketOnSale = null;

      int availableTicket;

      if(ticketOnSale == null)
      {
        Console.WriteLine("if executed");
        availableTicket = 0;
      }
      else
      {
        Console.WriteLine("else executed");
        //availableTicket = ticketOnSale.Value;
        //availableTicket = (int)ticketOnSale;
        availableTicket = ticketOnSale ?? 0;            
      }

      Console.WriteLine("availableTicket = {0}", availableTicket);
  }
}