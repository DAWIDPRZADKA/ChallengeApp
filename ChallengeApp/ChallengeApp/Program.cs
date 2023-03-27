using System.Xml.Linq;
using ChallengeApp;

Console.WriteLine("Witamy w Programie XYZ do oceny Pracowników");
Console.WriteLine("===========================================");
Console.WriteLine("Aby zakończyć wprowadzanie ocen i otrzymac statystykę naciśnij - q");
Console.WriteLine("");

var Employee1 = new Employee("Kamila", "Kowalska", "23", "Constructor");
var Employee2 = new Employee("Karolina", "Nowa", "18", "Secretary");
var Employee3 = new Employee("Michał", "Kot", "30", "Manager");

while (true)
{
    Console.WriteLine("Podaj ocenę pracownika E1: " + Employee1.Name + " " + Employee1.Surname + ", " + Employee1.Age + ", " + Employee1.Position);
    var input_1 = Console.ReadLine();
        if (input_1 == "q")
    {
        break;
    }
    try
    {
        Employee1.AddGrade(input_1);
    }
    catch(Exception e)
    {
        Console.WriteLine($"Pojawił się wyjątek: {e.Message}");
    }
}
var statistcis1 = Employee1.GetStatistics();

Console.WriteLine($"Average Letter - E1: {statistcis1.AverageLetter:N2}");
Console.WriteLine($"Average - E1: {statistcis1.Average:N2}");
Console.WriteLine($"Min - E1: {statistcis1.Min}");
Console.WriteLine($"Max- E1: {statistcis1.Max}");

while (true)
{
    Console.WriteLine("Podaj ocenę pracownika E2: " + Employee2.Name + " " + Employee2.Surname + ", " + Employee2.Age + ", " + Employee2.Position);
    var input_2 = Console.ReadLine();
    if (input_2 == "q")
    {
        break;
    }
    try
    {
        Employee2.AddGrade(input_2);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Pojawił się wyjątek: {e.Message}");
    }
}
var statistcis2 = Employee2.GetStatistics();

Console.WriteLine($"Average Letter - E2: {statistcis2.AverageLetter:N2}");
Console.WriteLine($"Average - E2: {statistcis2.Average:N2}");
Console.WriteLine($"Min - E3: {statistcis2.Min}");
Console.WriteLine($"Max- E3: {statistcis2.Max}");

while (true)
{
    Console.WriteLine("Podaj ocenę pracownika E3: " + Employee3.Name + " " + Employee3.Surname + ", " + Employee3.Age + ", " + Employee3.Position);
    var input_3 = Console.ReadLine();
    if (input_3 == "q")
    {
        break;
    }
    try
    {
        Employee3.AddGrade(input_3);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Pojawił się wyjątek: {e.Message}");
    }
}
var statistcis3 = Employee3.GetStatistics();

Console.WriteLine($"Average Letter - E3: {statistcis3.AverageLetter:N2}");
Console.WriteLine($"Average - E3: {statistcis3.Average:N2}");
Console.WriteLine($"Min - E3: {statistcis3.Min}");
Console.WriteLine($"Max- E3: {statistcis3.Max}");