using System;
//To create class we use class keyword with name of class as customer
class Customer
{
  string _firstName;  //these two field represented as data, state
  string _lastName;

  //To initialized these field class also have constructor.
  public Customer(string firstname, string lastname)  //public as access modifiers and name of the class.
  {
    this._firstName = firstname; //this - refer instance of the class/Object of the class.
    this._lastName = lastname;
  }
  // this constructor get called automatically when we create instnace of the class.

  public void fullName()
  {
    
  }
}

class Program
{
  static void Main()
  {

  }
}

//Example - Customer has firstname, lastname, email, DOB etc. do certain thing like save the data, mail the data.
//class consist of data and behaviour - class data represented by its field and behaviour is represented by methods.