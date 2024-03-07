using System;

public class Customer
{
    protected int ID;
} 

public class CorporateCustomer : Customer
{
    public void PrintID()
    {
        CorporateCustomer CC = new CorporateCustomer();
        CC.ID = 101;
    }
}

class Program
{
  private static void Main()
    {
        Customer C1 = new Customer();
        Console.WriteLine(C1.ID); // Compiler Error : 'Customer._id' is inaccessible due to its protection level

    }
}