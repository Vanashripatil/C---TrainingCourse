using System;

class Program
{
  static void Main(string[] args)
    {
        Program newStudent = null;
          
        try
        {               
            newStudent = new Program();
            newStudent.StudentName = "Pune01";
            
            ValidateStudent(newStudent);
        }
        catch(InvalidStudentNameException ex)
        {
            Console.WriteLine(ex.Message );
        }
          

        Console.ReadKey();
    }

    private static void ValidateStudent(Program std)
    {
        Regex regex = new Regex("^[a-zA-Z]+$");

        if (!regex.IsMatch(std.StudentName))
             throw new InvalidStudentNameException(std.StudentName);
            
    }
}