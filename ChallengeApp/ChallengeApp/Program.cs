using System.Xml.Linq;
using ChallengeApp;

var Employee1 = new Employee("Kamila", "Kowalska", "23");
var Employee2 = new Employee("Karolina", "Nowa", "18");
var Employee3 = new Employee("Michał", "Kot", "30");

Employee1.AddGrade(10);
Employee1.AddGrade(4);
Employee1.AddGrade(6);
Employee1.AddGrade(4);
Employee1.AddGrade(3);

Employee2.AddGrade(1);
Employee2.AddGrade(3);
Employee2.AddGrade(2);
Employee2.AddGrade(8);
Employee2.AddGrade(7);

Employee3.AddGrade(5);
Employee3.AddGrade(6);
Employee3.AddGrade(9);
Employee3.AddGrade(9);
Employee3.AddGrade(9);

var statistcis1 = Employee1.GetStatistics();
var statistcis2 = Employee2.GetStatistics();
var statistcis3 = Employee3.GetStatistics();


Console.WriteLine($"Average - E1: {statistcis1.Average:N2}");
Console.WriteLine($"Min - E1: {statistcis1.Min}");
Console.WriteLine($"Max- E1: {statistcis1.Max}");

Console.WriteLine($"Average - E2: {statistcis2.Average:N2}");
Console.WriteLine($"Min - E2: {statistcis2.Min}");
Console.WriteLine($"Max- E2: {statistcis2.Max}");

Console.WriteLine($"Average - E3: {statistcis3.Average:N2}");
Console.WriteLine($"Min - E3: {statistcis3.Min}");
Console.WriteLine($"Max- E2: {statistcis3.Max}");