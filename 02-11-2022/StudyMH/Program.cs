using System;

public class Employee
{
  public string FirstName;
  public string LastName;

  public void PrintFullName()
  {
    Console.WriteLine(FirstName + " " + LastName);
  }
}

public class PartimeEmployee : Employee
{
  //if I provide same function as base class in derived class
  //What happen is this method will hide the base containing method.
  //If you want to hide base class member, we use new keyword
  public void PrintFullName()
  {
    //base.PrintFullName();  We use base keyword to call base class methods
    Console.WriteLine(FirstName + " " + LastName + " - con" );
  }
}

public class FullTimeEmployee : Employee
{

}

class Program
{
  static void Main()
  {
    FullTimeEmployee FTE = new FullTimeEmployee();
    FTE.FirstName = "Pune";
    FTE.LastName = "Wakad";
    FTE.PrintFullName();

    Employee PTE1 = new PartimeEmployee(); //Parent class reference variable can point to child class object
    PartimeEmployee PTE = new PartimeEmployee();
    PTE.FirstName = "Vune";
    PTE.LastName = "Wakad";
    PTE.PrintFullName();
  }
}