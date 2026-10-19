using ConsoleApp;

namespace ConsoleAppTests;

public class UnitTest1
{
    public void ThisIsNotATest()
    {

    }

    [Fact]
    public async Task Student_Id_DefaultsToZero()
    {
        var student = new Student();

        Assert.Equal(0, student.Id);

        //await Task.Delay(150);
        await Task.Yield();
    }

    [Theory]
    [InlineData(1)]
    [InlineData(25)]
    [InlineData(999)]
    [InlineData(int.MaxValue)]
    public void Student_Id_CanBeAssigned(int id)
    {
        var student = new Student();

        student.Id = id;

        Assert.Equal(id, student.Id);
    }

    [Fact]
    public void Student_Id_CanBeUpdatedMultipleTimes()
    {
        var student = new Student();

        student.Id = 10;
        student.Id = 20;
        student.Id = 30;

        Assert.Equal(30, student.Id);
    }

    [Fact]
    public void Different_Students_HaveIndependentIds()
    {
        var student1 = new Student { Id = 3 };
        var student2 = new Student { Id = 7 };

        Assert.Equal(3, student1.Id);
        Assert.Equal(7, student2.Id);
    }

    [Fact]
    public void Student_Id_AllowsNegativeValues()
    {
        var student = new Student();

        student.Id = -5;

        Assert.Equal(-5, student.Id);
    }

    [Fact]
    public void PrintSchoolName_WritesExpectedText()
    {
        var student = new Student();
        student.Id = 1;
        using var writer = new StringWriter();
        var originalOut = Console.Out;
        // some changes
        try
        {
            Console.SetOut(writer);

            student.PrintSchoolName();

            Assert.Equal($"Dometrain!{Environment.NewLine}", writer.ToString());
        }
        finally
        {
            Console.SetOut(originalOut);
        }
    }

    [Fact]
    public void PrintSchoolName_CalledThreeTimes_WritesThreeLines()
    {
        var student = new Student();
        
        using var writer = new StringWriter();
        var originalOut = Console.Out;

        try
        {
            Console.SetOut(writer);

            student.PrintSchoolName();
            student.PrintSchoolName();
            student.PrintSchoolName();

            var expected = string.Concat(
                $"Dometrain!{Environment.NewLine}",
                $"Dometrain!{Environment.NewLine}",
                $"Dometrain!{Environment.NewLine}");

            Assert.Equal(expected, writer.ToString());
        }
        finally
        {
            Console.SetOut(originalOut);
        }
    }

    [Fact]
    public void PrintSchoolName_OutputContainsDometrain()
    {
        var student = new Student();
        using var writer = new StringWriter();
        var originalOut = Console.Out;

        try
        {
            Console.SetOut(writer);

            student.PrintSchoolName();

            Assert.Contains("Dometrain", writer.ToString());
        }
        finally
        {
            Console.SetOut(originalOut);
        }
    }

    [Fact]
    public void PrintSchoolName_OutputIsNotEmpty()
    {
        var student = new Student();
        using var writer = new StringWriter();
        var originalOut = Console.Out;

        try
        {
            Console.SetOut(writer);

            student.PrintSchoolName();

            Assert.False(string.IsNullOrWhiteSpace(writer.ToString()));
        }
        finally
        {
            Console.SetOut(originalOut);
        }
    }
}
