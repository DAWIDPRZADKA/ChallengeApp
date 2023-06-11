using ChallengeApp;

Console.WriteLine("Witamy w Programie XYZ do oceny Pracowników");
Console.WriteLine("===========================================");
Console.WriteLine("Aby zakończyć wprowadzanie ocen i otrzymac statystykę naciśnij - q");
Console.WriteLine("");

var Employee1 = new EmployeeInFile("Kamila", "Kowalska", "23", "Constructor");

Employee1.GradeAdded += Employee1GradeAdded;

void Employee1GradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}


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