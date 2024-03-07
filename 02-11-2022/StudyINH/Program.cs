using System;

//inheritance promote reusability.
//Base class can be reuse across derived classes.
//Base class
public class Employee
{
  public string FirstName; //These field are private 
  public string LastName;
  public string Emai;

  public void PrintFullName()
  {}
}

//Derived class
//Derived class inheriting base class, so We can access all member variale of the base class.
//you will speicify all the common field, properties, methods in a base class, which allows reusability.
//In derived class you will have field, properties, methods, that are specified to them.
public class FullTimeEmployee : Employee
{
  public float YearlySalary;
}

public class PartTimeEmployee : Employee
{
  public float HourlyRate;
}

class Program
{
  static void Main()
  {

  }
}