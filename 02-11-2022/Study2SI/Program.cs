using System;

class Circle
{
  //static can be class, field, method, constructor even delegates.
  //These field are instance field/Member and non-static field.
  static float PI; //this field is static field.
  int _radius;

  //Constructor can be static constructor
  //To initialize static field we use static constructor.
  //access modifier are not allowed on static constructor.
  static Circle()
  {
    Circle.PI = 3.14F;
  }
  public Circle(int radius)
  {
    this._radius = radius;
  }
  // static method
  public static void Print()
  {

  } 

  public float CalulateArea()
  {
    return this.PI * this._radius * this._radius;
  }
}
class Program
{
  static void Main()
  {
    Circle C1 = new Circle(5);
    float area1 = C1.CalulateArea();
    //To call print method, we use name of the class.
    Circle.Print();
    Console.WriteLine("Area : {0}", area1);

    Circle C2 = new Circle(6);
    float area2 = C2.CalulateArea();
    Console.WriteLine("Area : {0}", area2);
  }
}

//If we check here Circle 1 has radius 5 and PI value is 3.14 and Circle 2 has radius 6 and PI value is 3.14
//PI value is constant not gooing to change. on pair object we created and thats going to be static.

//If we create circle 1 object - fields created in memory. if we create circle 2 object - same copy we be created in memory
//PI value is duplicated. value is not change its constant So we make it static
//If we make it static then in memory only one copy of that PI which will be shared by all object to be created.
//When we make field static, we cannot called that field with this keyword.
//AS this PI is not called pair object basis so we cannot called using this keyword. instead we refer as name of the class.

//Static member invoked using name of the class where as instance member invoked using instance nad object of the class.
//only copy created in memory no matter how many object you will create

//If I remove access modifier of class member by default they are private and can be access only inside that class.
//Static constructor need not be called. when oyu refer static field, constructor will be automatically
//called even before to initialized the static field.

//Static constructor called only once, no matter how many instance you have created.
//Static constructor called before instance constructor.