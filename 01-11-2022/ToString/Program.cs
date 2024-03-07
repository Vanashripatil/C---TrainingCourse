using System;

class Program
{
  static void Main()
  {
    Customer C1 = new Customer();  // Create new instance of the class
    string str = Convert.ToString(C1); // To get string representation of C1, use ToString() method.
                                       // We get string representation of the customer object.
                                       // To hold value, create string variable.
                                       // ToString method coming from base system.object class
      
    Console.WriteLine(str);
  }
}

public class Customer                // overridden ToString method.
{
   public string print{get; set;}
}


//Senario - If customer object reference variable i.e C1 is null or you are passing parameter as method and do not initialize that
//Passing null object to the ToString method in the Convert Class - It convert null into empty string.
//C1 i.e reference variable is null and on that null you are trying to call instant ToString() method -- We get null reference error.
// C1 is not pointing to any location on heap memory.