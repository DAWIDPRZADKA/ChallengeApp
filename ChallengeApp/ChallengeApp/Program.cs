using System.Xml.Linq;
using ChallengeApp;

Employee Employee1 = new Employee("Kamila", "Kowalska", "23");
Employee Employee2 = new Employee("Karolina", "Nowa", "18");
Employee Employee3 = new Employee("Michał", "Kot", "30");

Employee1.AddScore(10);
Employee1.AddScore(4);
Employee1.AddScore(6);
Employee1.AddScore(4);
Employee1.AddScore(3);

Employee2.AddScore(1);
Employee2.AddScore(3);
Employee2.AddScore(2);
Employee2.AddScore(8);
Employee2.AddScore(7);

Employee3.AddScore(5);
Employee3.AddScore(6);
Employee3.AddScore(9);
Employee3.AddScore(9);
Employee3.AddScore(9);

List<Employee> Employees = new List<Employee>()
{
    Employee1,  Employee2,  Employee3
};

int maxResult = -1;
Employee EmployeeWithMaxResult = null;

foreach(var Employee in Employees)
{
    if (Employee.Result > maxResult)
    {
        EmployeeWithMaxResult = Employee;
    }
}


Console.WriteLine("Pracownik z największą liczbą punktów:");
Console.WriteLine("Imię -" + " " + EmployeeWithMaxResult.Name);
Console.WriteLine("Nazwisko -" + " " + EmployeeWithMaxResult.Surname);
Console.WriteLine("Wiek -" + " " + EmployeeWithMaxResult.Age);
Console.WriteLine("Punkty -" + " " + EmployeeWithMaxResult.Result);
