using System;

abstract class Animal {
    
    public Animal() {
      Console.WriteLine("Animal Constructor");
    }
  }

  class Dog : Animal {
    public Dog() {
      Console.WriteLine("Dog Constructor");
    }   
  }
  
class Program
{
  static void Main (string [] args) {
      Dog d1 = new Dog();  

      Console.ReadLine();
    }
}