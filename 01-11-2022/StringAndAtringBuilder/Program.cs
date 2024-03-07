//System.String is immutable
//stringBuilder is mutable

using System;
using System.Text;

class Program
{
  static void Main()
  {
    string userStr = "C#"; // string of the type system.string present in system.string namespace
    userStr += " tutorial";  // immutable
    Console.WriteLine(userStr);

    StringBuilder userStr1 = new StringBuilder("C#"); //stringbuilder is present in system.text namespace.
    userStr1.Append(" tutorials");  //mutable
    Console.WriteLine(userStr1.ToString()); // becase of this we have better performanace in stringbuilder object
                                           //over system.string if there is heavy string manupulation is involved.
  }
}