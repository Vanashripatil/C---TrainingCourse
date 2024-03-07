using System;

class Program
{
  static void Main()
  {
    customer c1 = new customer();
    c1.firstName = "Wakad";
    c1.lastName = "pune";

    customer c2 = new customer();
    c2.firstName = "Wakad";
    c2.lastName = "pune";

    Console.WriteLine(c1 == c2); //false
    Console.WriteLine(c1.Equals(c2)); //false
  }
}

public class customer
{
  public string firstName { get; set; }
  public string lastName { get; set; }

  public override bool Equals(object obj)
  {
    if(obj == null)
    {
      return false;
    }
    if(!(obj is customer))
    {
      return false;
    }
    return this.firstName == (customer)obj
  }

}