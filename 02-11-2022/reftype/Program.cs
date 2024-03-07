using System;

class Student
{
  public string name {get; set;}
}

class Program
{
  static void ChangeName(Student std)
  {
    std.name = "Hill";
  }
  static void Main()
  {
    Student std = new Student();
    std.name = "Bill";

    ChangeName(std);

    Console.WriteLine(std.name);
  }
}