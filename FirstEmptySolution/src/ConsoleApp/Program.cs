using System.Collections;
using System.Text.RegularExpressions;
using ConsoleApp;
using Microsoft.Extensions.Logging;

// This file contains a minimal console application used for demo and diagnostics.
// The top-level statements exercise simple arithmetic, logging hooks, file reads,
// and some async/parallel patterns. Many methods are local functions used only
// by this Program file and documented below for clarity.

//ReadFiles();
//RunAsync();




#region CommandLine & Environment Variables

//string[] r = args; // Environment.GetCommandLineArgs()
//foreach (string item in r)
//{
//    Console.WriteLine("Val: {0}", item);
//}

//Console.WriteLine("\n\n");

//IDictionary envVariables = Environment.GetEnvironmentVariables();
//foreach (object item in envVariables)
//{
//    string varText = item.ToString();
//    if (varText.Contains("DOMETRAIN"))
//    {
//        Console.WriteLine("Var: {0}", item);
//    }
//}

//Console.ReadLine();
//return;

#endregion


#if MY_LOCAL_PC
await ExecuteTimePrinting();
#endif


ILogger _logger = null; // it is acceptable to be null
var order = new Order() { Id = 1, Price = 10.99, ProductName = "Pen" };

//_ = Order.From(,, )


var regex = new Regex("^[0-9]*$");



var hwText = "Hello, World!";

Console.WriteLine(hwText);


//return;

int counter = 20_000_000;

for (int i = 0; i < counter; i++)
{
    var forVariable = counter + i;

    // BUG: Why is this here?
    if (i > 100)
    {
        /* question: Test Q1 */
        // Question Why is this commented out?
        //Debugger.Break();
    }

    var sumInt1 = SumInt(1, 2);
}

Console.WriteLine();





var sumInt = SumInt(3, 5);

if (sumInt > 10)
{
    Console.WriteLine("The total is greater than 10");
}

sumInt = 9;

var sumDouble = SumDouble(4.5, 5);



//try
//{
//var div = Divide(10, 0);
List<int> intNumbers = null;



ArgumentNullException.ThrowIfNull(intNumbers);
//}
//catch (ArgumentNullException ex)
//{
//    Console.WriteLine("Divison error");
//}

List<int> numbers = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];
numbers.Add(0);

// this is from visual studio
GenerateStrings();

Console.WriteLine("*-");

Console.WriteLine("press enter to exit");
Console.ReadKey();


async Task ExecuteTimePrinting()
{
    while (true)
    {
        PrintDateTime(false);
        await Task.Delay(TimeSpan.FromSeconds(1));
    }
}

void PrintDateTime(bool showMilliseconds)
{
    var value = $"{DateTime.Now:HH:mm:ss}";
    if (showMilliseconds)
        value = $"{DateTime.Now:HH:mm:ss fff zzz}";

    Console.WriteLine(value);
}




#region Private Methods

bool IsCapital1(string str)
{
    ArgumentNullException.ThrowIfNull(str);

    return true;
}

bool IsPrimeNumber(int number)
{
    int x = 10;


    if (number < 1)
    {
        return false;
    }

    if (number == 2)
    {
        return true;
    }

    if (number % 2 == 0)
    {
        return false;
    }

    var boundary = (int)Math.Floor(Math.Sqrt(number));

    for (int i = 3; i <= boundary; i += 2)
    {
        if (number % i == 0)
        {
            return false;
        }

        continue;
    }

    return true;
}

// function that returns any given number is Super Number or not
bool IsSuperNumber(int number)
{
    int sum = 0;
    int temp = number;

    while (temp > 0)
    {
        sum += temp % 10;
        temp /= 10;
    }

    return IsPrimeNumber(sum);
}


int SumInt(int x, int y)
{
    void PrintDateTime()
    {
        Console.WriteLine(DateTime.Now.ToString());
    }
    
    var total = x + y;

    _logger?.LogInformation("Order created: {0} ", order.Id);
    _logger?.LogInformation("Order created: {0} ", order.Id);


    return total;
}

double SumDouble(double x, double y)
{
    /// <summary>
    /// Adds two double precision operands and returns their sum.
    /// </summary>
    /// <param name="x">The first double addend.</param>
    /// <param name="y">The second double addend.</param>
    /// <returns>The sum of <paramref name="x"/> and <paramref name="y"/> as a <see cref="double"/>.</returns>
    /// <remarks>
    /// Uses the instance logger (if present) to emit a diagnostic message referencing
    /// the current <c>order</c> object. Floating point rounding semantics apply.
    /// </remarks>
    _logger?.LogInformation("Order created: {0} ", order.Id);


    return x + y;
}

double Divide(int y,
              int x)
{
    ArgumentOutOfRangeException.ThrowIfNegative(y);
    ArgumentOutOfRangeException.ThrowIfNegativeOrZero(x);

    _logger?.LogInformation("Order created: {0} ", order.Id);
    _logger?.LogInformation("Order created: {0} ", order.Id);

    return x / y;
}


async Task Wait(int milliseconds)
{

    await Task.Delay(milliseconds);
}


void ReadFiles()
{
    var text = "Salih Cantekin in DomeTrain";
    text = text.ToUpper();

    var commentsJson = File.ReadAllText("Docs\\Comments.json");
    commentsJson = commentsJson.ToUpper();

    var loremIpsumText = File.ReadAllText(@"Docs\LoremIpsum.txt");
    loremIpsumText = loremIpsumText.ToUpper();

    var postsJson = File.ReadAllText(Path.Combine("Docs", "Posts.json"));



    List<Order> orders =
    [
        new Order() { Id = 1,Price = 10.99,  ProductName = "Pen" },
        new Order() { Id = 2,Price = 12.99,  ProductName = "Notebook" },
        new Order() { Id = 3,Price = 119.99, ProductName = "Smart TV" }
    ];

    var order = orders.First();



    try
    {
        _logger?.LogInformation("Order updated: {0} ", order.Id);
        _logger?.LogInformation("Order created: {0} ", order.Id);
    }
    catch
    {
    }

}



void GenerateStrings()
{
    // Qeustion: does this need to be 10K?
    int counter = 10_000;
    string numbers = "";

    for (int i = counter - 1; i >= 0; i--)
    {
        // Salih: Fix this by using StringBuilder
        numbers += i.ToString();
    }
}

async Task RunAsync()
{
    // TODO: Improve async usage
    Task.Run(async () =>
    {
        while (true)
        {
            Console.WriteLine("DateTime: {0}", DateTime.Now.ToLongTimeString());
            await Task.Delay(1_000);
        }
    });

    int counter = 0;
    Parallel.For(0, 100, async i =>
    {
        await Task.Delay(100);
        Interlocked.Increment(ref counter);
        await Task.Delay(100);
    });
}

#endregion

#region UserService Objects

public class BaseUserClass
{

}

public interface IUserService
{
    abstract string GetName();
}

public class UserService : BaseUserClass, IUserService
{
    public UserService()
    {

    }

    public string GetName()
    {
        var student = new Student();
        student.PrintSchoolName();

        return "";
    }
}

#endregion

public enum UserType
{
    Child,
    Adult,
    Senior
}

/*
 
Powershell Arguments;

-NoExit -Command "& { Import-Module """$env:VSAPPIDDIR\..\Tools\Microsoft.VisualStudio.DevShell.dll"""; Enter-VsDevShell -SkipAutomaticLocation -SetDefaultWindowTitle -InstallPath $env:VSAPPIDDIR\..\..\}"
 
 
 */


//public interface IDomeTrain
//{

//}







