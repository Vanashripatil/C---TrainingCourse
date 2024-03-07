using System;

class Program
{
  static void Main()
  {
      int i =100;
      float f = i;
      Console.WriteLine(f);

      float f1= 0.123F;
      int i1 = (int)f1;
      Console.WriteLine(i1);

      string str = "100";
      int number = int.Parse(str);
      Console.WriteLine(number);

      string str2 = "100TG";
      int result = 0;
      bool isConversionSuccessful = int.TryParse(str2, out result);
      if(isConversionSuccessful)
      {
        Console.WriteLine(result);
      }
      else{
        Console.WriteLine("please enter valid number");
      }
  }
}