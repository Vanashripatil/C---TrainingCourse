using System;

abstract class MotorBike {
  public abstract void brake();
}

  class SportsBike : MotorBike {
    public override void brake() {
      Console.WriteLine("Sports Bike Brake");
    }
   
  }

  class MountainBike : MotorBike {
    public override void brake() {      
      Console.WriteLine("Mountain Bike Brake");
    }
   
  }

class Program
{
  static void Main()
  {
    SportsBike s1 = new SportsBike();  
    s1.brake();

    MountainBike m1 = new MountainBike();
    m1.brake();

  }
}