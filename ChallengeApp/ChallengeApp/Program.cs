using System.Xml.Linq;
using ChallengeApp;

var Employee1 = new Employee("Kamila", "Kowalska", "23");
var Employee2 = new Employee("Karolina", "Nowa", "18");
var Employee3 = new Employee("Michał", "Kot", "30");

Employee1.AddGrade(10);
Employee1.AddGrade(4);
Employee1.AddGrade("6");
Employee1.AddGrade(3);
Employee1.AddGrade("cztery");

Employee2.AddGrade(1);
Employee2.AddGrade("3");
Employee2.AddGrade(2);
Employee2.AddGrade("8");
Employee2.AddGrade("siedem");

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

var statistcis4 = Employee1.GetStatisticsWithForEach();
var statistcis5 = Employee2.GetStatisticsWithForEach();
var statistcis6 = Employee3.GetStatisticsWithForEach();

Console.WriteLine($"GetStatisticsWithForEach:");
Console.WriteLine($"Average - E1: {statistcis4.Average:N2}");
Console.WriteLine($"Min - E1: {statistcis4.Min}");
Console.WriteLine($"Max- E1: {statistcis4.Max}");

Console.WriteLine($"Average - E2: {statistcis5.Average:N2}");
Console.WriteLine($"Min - E2: {statistcis5.Min}");
Console.WriteLine($"Max- E2: {statistcis5.Max}");

Console.WriteLine($"Average - E3: {statistcis6.Average:N2}");
Console.WriteLine($"Min - E3: {statistcis6.Min}");
Console.WriteLine($"Max- E2: {statistcis6.Max}");

var statistcis7 = Employee1.GetStatisticsWithDoWhile();
var statistcis8 = Employee2.GetStatisticsWithDoWhile();
var statistcis9 = Employee3.GetStatisticsWithDoWhile();

Console.WriteLine($"GetStatisticsWithDoWhile:");
Console.WriteLine($"Average - E1: {statistcis7.Average:N2}");
Console.WriteLine($"Min - E1: {statistcis7.Min}");
Console.WriteLine($"Max- E1: {statistcis7.Max}");

Console.WriteLine($"Average - E2: {statistcis8.Average:N2}");
Console.WriteLine($"Min - E2: {statistcis8.Min}");
Console.WriteLine($"Max- E2: {statistcis8.Max}");

Console.WriteLine($"Average - E3: {statistcis9.Average:N2}");
Console.WriteLine($"Min - E3: {statistcis9.Min}");
Console.WriteLine($"Max- E2: {statistcis9.Max}");

var statistcis10 = Employee1.GetStatisticsWithWhile();
var statistcis11 = Employee2.GetStatisticsWithWhile();
var statistcis12 = Employee3.GetStatisticsWithWhile();

Console.WriteLine($"GetStatisticsWithWhile:");
Console.WriteLine($"Average - E1: {statistcis10.Average:N2}");
Console.WriteLine($"Min - E1: {statistcis10.Min}");
Console.WriteLine($"Max- E1: {statistcis10.Max}");

Console.WriteLine($"Average - E2: {statistcis11.Average:N2}");
Console.WriteLine($"Min - E2: {statistcis11.Min}");
Console.WriteLine($"Max- E2: {statistcis11.Max}");

Console.WriteLine($"Average - E3: {statistcis12.Average:N2}");
Console.WriteLine($"Min - E3: {statistcis12.Min}");
Console.WriteLine($"Max- E2: {statistcis12.Max}");