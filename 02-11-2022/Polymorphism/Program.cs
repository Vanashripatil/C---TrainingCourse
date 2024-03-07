using System;

class Animal
{
  public virtual void AnimalSound()
  {
    Console.WriteLine("Animal sound like");
  }
}

class PigAnimal : Animal
{
  public override void AnimalSound()
  {
    Console.WriteLine("Pig sound like");
  }
}
class Program
{
  static void Main()
  {
    Animal ani = new Animal();
    Animal pani = new PigAnimal();
    ani.AnimalSound();
    pani.AnimalSound();


  }
}