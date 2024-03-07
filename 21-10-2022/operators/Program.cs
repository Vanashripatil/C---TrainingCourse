using System;

class Program
{
  static void Main()
  {
    int numerator = 10;
    int denominator = 2;

    int result = numerator / denominator;
    Console.WriteLine("result = {0}",result);

    if(numerator == 10){
      Console.WriteLine("true");
    }else{
      Console.WriteLine("false");
    }

    if(numerator == 10 && denominator == 2){
      Console.WriteLine("true");
    }else{
      Console.WriteLine("false");
    }

    bool isNumber;
    isNumber = numerator == 10 ? true : false;
    Console.WriteLine("ternary = {0}", isNumber);
  }
}