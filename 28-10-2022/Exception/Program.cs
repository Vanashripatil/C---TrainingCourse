using System;

class Program
{
  int result;
      
  void DivNumbers() {
    result = 0;
  }
    
  public void division(int num1, int num2) {
    try {
      result = num1 / num2;
    } catch (DivideByZeroException e) {
      Console.WriteLine("Exception caught: {0}", e);
    } finally {
      Console.WriteLine("Result: {0}", result);
    }
  }
  static void Main()
  {
    Program ps = new Program();
    ps.division(25, 0);
  }
}