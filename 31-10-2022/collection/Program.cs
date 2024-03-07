using System;
using System.Collections.Generic;

class Program
{
  static void Main(String[] args)
  {
    IDictionary<int, string> numbers = new Dictionary<int, string>();
    numbers.Add(1, "ONE");
    numbers.Add(2, "TWO");
    numbers.Add(3, "THREE");

    foreach (var item in numbers)
    {
      Console.WriteLine("Key: {0}, value: {1}", item.Key, item.Value);
    }
  }
}