using System;

public class ParentClass
{
  public ParentClass()
  {
    Console.WriteLine("Parent Class is called");
  }
  public ParentClass(string message)
  {
    Console.WriteLine(message);
  }
}

public class ChildClass : ParentClass
{
  public ChildClass() : base("Derived class controlling parent class")
  {
    Console.WriteLine("Child Class is Called");
  }
}

class Inheritance
{
  static void Main()
  {
    ChildClass c1 = new ChildClass();
  }
}