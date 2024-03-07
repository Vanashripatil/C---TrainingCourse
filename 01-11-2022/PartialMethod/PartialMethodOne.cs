using System;

public partial class PartialMethodOne
{
  partial void samplepartialMethod();  //private by default

  public void publicMethod()
  {
    Console.WriteLine("Public Method involved");
    samplepartialMethod();
  }
}