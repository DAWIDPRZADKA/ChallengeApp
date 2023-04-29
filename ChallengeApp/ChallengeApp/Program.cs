using ChallengeApp;

Console.WriteLine("Witamy w Programie XYZ do oceny Pracowników");
Console.WriteLine("===========================================");
Console.WriteLine("Aby zakończyć wprowadzanie ocen i otrzymac statystykę naciśnij - q");
Console.WriteLine("");

var Employee1 = new EmployeeInMemory("Kamila", "Kowalska", "23", "Constructor");
var Employee2 = new EmployeeInMemory("Karolina", "Nowa", "18", "Secretary");
//var Supervisor1 = new Supervisor("Michał", "Kot", "30", "Manager");

Employee1.GradeAdded += Employee1GradeAdded;

void Employee1GradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}

Employee1.AddGrade(11.5f);
Employee1.AddGrade(4.5f);
Employee1.AddGrade(8);
Employee1.AddGrade(8);

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
    catch (Exception e)
    {
        Console.WriteLine($"Pojawił się wyjątek: {e.Message}");
    }
}
var statistcis1 = Employee1.GetStatistics();

Console.WriteLine($"Average Letter - E1: {statistcis1.AverageLetter:N2}");
Console.WriteLine($"Average - E1: {statistcis1.Average:N2}");
Console.WriteLine($"Min - E1: {statistcis1.Min}");
Console.WriteLine($"Max- E1: {statistcis1.Max}");

Employee2.GradeAdded += Employee2GradeAdded;

void Employee2GradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}

Employee2.AddGrade(3.8f);
Employee2.AddGrade(2.8f);

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

//while (true)
//{
//    Console.WriteLine("Podaj ocenę pracownika S1: " + Supervisor1.Name + " " + Supervisor1.Surname + ", " + Supervisor1.Age + ", " + Supervisor1.Position);
//    var input_S1 = Console.ReadLine();
//    if (input_S1 == "q")
//    {
//        break;
//    }
//    try
//    {
//        Supervisor1.AddGrade(input_S1);
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine($"Pojawił się wyjątek: {e.Message}");
//    }
//}
//var statistcisS1 = Supervisor1.GetStatistics();

//Console.WriteLine($"Average Letter - S1: {statistcisS1.AverageLetter:N2}");
//Console.WriteLine($"Average - S1: {statistcisS1.Average:N2}");
//Console.WriteLine($"Min - S1: {statistcisS1.Min}");
//Console.WriteLine($"Max- S1: {statistcisS1.Max}");