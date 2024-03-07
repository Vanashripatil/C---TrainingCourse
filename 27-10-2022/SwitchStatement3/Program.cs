using System;

class Program
{
  static void Main()
  {
    int totalBill = 0;

    Start:
    Console.WriteLine("Please Select Coffie Size : 1 - Small, 2 - Medium, 3 - Large");
    int userChoice = int.Parse(Console.ReadLine());

    switch (userChoice)
    {
      case 1:
         totalBill += 1;
         break;
      case 2:
         totalBill +=2;
         break;
      case 3:
         totalBill +=3;
         break;
      default:
         Console.WriteLine("Your choice is {0} invalid", userChoice);
         goto Start;
    }

    decide:
    Console.WriteLine("Do you want to continue shopping with us ?");
    string userDecision = Console.ReadLine();

    switch (userDecision.ToUpper())
    {
      case "YES":
        goto Start;
      case "NO":
        break; 
      default:
        Console.WriteLine("Your choice is {0} invalid", userDecision);
        goto decide;
    }

    Console.WriteLine("Thank you for shopping with us");
    Console.WriteLine("Your Total bill is {0}", totalBill);
  }
}