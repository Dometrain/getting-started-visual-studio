using System.Runtime.CompilerServices;

namespace ConsoleApp;

public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }
    
    public void PrintSchoolName()
    {
        // Email, EmailAddress
        string email = "Email";
        //if (Id != 0)
        Console.WriteLine("Dometrain!");
        //else
        //    Console.WriteLine("Dometrain with zero id!");
    }
}
