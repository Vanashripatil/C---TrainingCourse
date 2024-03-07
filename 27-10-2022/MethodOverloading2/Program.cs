using System;

class Program {  

    //int parameter
    void display(int a) {
      Console.WriteLine("int : " + a);
    } 

    //string parameter
    void display(string b) {
      Console.WriteLine("string : " + b);
    } 
    static void Main(string[] args) {

      Program p1 = new Program();
      p1.display(100);
      p1.display("Pune");
      Console.ReadLine();
    }
  }