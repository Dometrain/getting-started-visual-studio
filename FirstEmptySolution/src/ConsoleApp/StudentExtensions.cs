using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp;

[ExcludeFromCodeCoverage]
public static class StudentExtensions
{
    public static Student ToStudent(string name, string lastName)
    {
        return new Student()
        {
            Id = 1,
            FirstName = name,
            LastName = lastName,
            EmailAddress = $"{name}.{lastName}@gmail.com"
        };
    }
}