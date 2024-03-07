

class Program
{
  static void Main()
  {
    Console.WriteLine("Enter the number");
    int username = Convert.ToInt32(Console.ReadLine());
    
    switch (username)
    {
      case 10:Console.WriteLine("number is 10");
              break;
      case 20:Console.WriteLine("number is 20");
              break;
      case 30:Console.WriteLine("number is 30");
              break;
      default:Console.WriteLine("number are not 10, 20 or 30");
              break;
    }
  }
}