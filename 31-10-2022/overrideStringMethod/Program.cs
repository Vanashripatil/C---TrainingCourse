using System;

class Program
{
  private static void Main()
  {
    int number = 10;
    Console.WriteLine(number.ToString());

    customer c1 = new customer();
    c1.FirstName = "wakad";
    c1.LastName = "pune";

    Console.WriteLine(c1.ToString());
  }
}

public class customer
{
    public string FirstName {get; set;}
    public string LastName {get; set;}

    public override string ToString()
    {
      return this.FirstName + " " + this.LastName;
    }
}