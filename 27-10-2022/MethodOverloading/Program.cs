using System;

class Program
{
  //one parameter
    void display(int a) {
      Console.WriteLine("Arguments: " + a);
    }
 
    //two parameters
    void display(int a, int b) {
      Console.WriteLine("Arguments: " + a + " and " + b);
    } 
    static void Main(string[] args) {

      Program p1 = new Program();
      p1.display(100);
      p1.display(100, 200);
      Console.ReadLine();
    }
}