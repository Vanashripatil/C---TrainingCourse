using System;

class Program
{
  private static void Main()
  {
    bool Equal = Calculator.AreEqual(1, 2);

    if(Equal)
    {
      Console.WriteLine("EQual");
    }
    else
    {
      Console.WriteLine("NotEQual");
    }
  }
}

public class Calculator
{
  public static bool AreEqual(Object value1, Object value2)
  {
    return value1 == value2;
  }
}