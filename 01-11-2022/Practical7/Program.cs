//C# Program to Reverse a Number and Check if it is a Palindrome
using System;

class Program
{
  static void Main()
  {
    int num, rev = 0, rem;
    Console.WriteLine("Enter the number");
    num = int.Parse(Console.ReadLine());
    int palindromeCheck = num;

    while(num != 0)
    {
      rem = num % 10;
      rev = rev * 10 + rem;
      num /= 10;
    }

    if(palindromeCheck == rev)
    {
      Console.WriteLine("yes");
    }
    else
    {
      Console.WriteLine("No");
    }
  }
}