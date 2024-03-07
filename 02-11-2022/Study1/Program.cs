using System;
//If you are using storing number then we store in variable
//but if you store customer information we store in a class. It has first name, last name, DOB, email etc. also do save the data and email the data.
//Class consist of data represented by its field and behaviour represented by its method
//To create a class we use class keyword followed with name of the class
class Customer
{
  string _firstName; //these two field represent the state.
  string _lastName;

  public Customer() : this("no naame", "no name"){}

  //To initialize these field the class also has a constructor
  //Constructor has same name that of the class
  //Constructor used to initialized the class field.
  //Constructor does not return any value
  //Constructor gets automatically call when we create instance of the class.
  public Customer(string FirstName, string LastName)
  {
    this._firstName = FirstName;  //this keyword refer instance of the class.
    this._lastName = LastName;
  }
  
  public void fullName()
  {
    Console.WriteLine("Full Name : {0} {1}", _firstName, _lastName);
  }

  //class also have destructor
  //same name as class name, cannot have return type.
  //Any code to clean up resources goes into destructor.
  ~Customer()
  {
    //clean up code
  }

}
class Program
{
  //If I want to use this class, we do in Main method - We create instance of the class with new keyword
  //This instance also called as object
  //When we create instance of the class constructor gets automaticllay getting called.
  //Customer C2 = new Customer();
  static void Main()
  {
    Customer C2 = new Customer();
    Customer C1 = new Customer("pune", "Wakad");
    C1.fullName();
    C2.fullName();
  }
  
  //IF you do not provide constructor to your class, it automatically called default constructor
}