using System;

class Program
{
      private string code = "000";
      private string name = "Tiranga";
      private int age = 0;
      
      public string Code {
         get {
            return code;
         }
         set {
            code = value;
         }
      }
      
      public string Name {
         get {
            return name;
         }
         set {
            name = value;
         }
      }
      
      public int Age {
         get {
            return age;
         }
         set {
            age = value;
         }
      }
      public override string ToString() {
         return "Code = " + Code +", Name = " + Name + ", Age = " + Age;
      }
   }
   
   class ExampleDemo {
      public static void Main() {
      
         Program s = new Program();
         
         s.Code = "001";
         s.Name = "Zara";
         s.Age = 9;
         Console.WriteLine("Student Info: {0}", s);
        
         s.Age += 1;
         Console.WriteLine("Student Info: {0}", s);
         Console.ReadKey();
      }
}