

using ChallengeApp;


Employee employee1 = new Employee("Jacek", "Pacek", 32);
Employee employee2 = new Employee("Paul", "Kraul", 33);
Employee employee3 = new Employee("Mark", "Markson", 46);

employee1.AddScore("5");
employee1.AddScore(10);
employee1.AddScore("5");
employee1.AddScore('B');
employee1.AddScore('a');

employee2.AddScore(1);
employee2.AddScore(6);
employee2.AddScore(5);
employee2.AddScore(9);
employee2.AddScore(2);

employee3.AddScore(7);
employee3.AddScore(1);
employee3.AddScore(4);
employee3.AddScore(6);
employee3.AddScore(4);

var result1 = employee1.Result;
var result2 = employee2.Result;
var result3 = employee3.Result;

List<Employee> employees = new List<Employee>()
{
   employee1, employee2, employee3
};

float maxResult = -1;
Employee empWithMaxResult = null;


foreach (var emp in employees)
{
    if (emp.Result > maxResult)
    {
        maxResult = emp.Result;
        empWithMaxResult = emp;
    }
}

Console.WriteLine("Witamy w progaramie do oceny pracownikow");
Console.WriteLine("=========================================");
Console.WriteLine();


Employee employee = new Employee("Jacek", "Pacek", 32);

while (true)
{
    Console.WriteLine("Podaj kolejna ocene pracownika: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try
    { 
        employee.AddScore(input); 
    }
    catch(Exception ex)
    {
        Console.WriteLine($"Exception catched: {ex.Message}");
    }
   
}

var statistics = employee.GetStatistics();
Console.WriteLine("Srednia ocen pracownika wynosi: " + statistics.Average);
Console.WriteLine("Minimalna ocena pracownika wynosi: " + statistics.Min);
Console.WriteLine("Maksymalna ocena pracownika wynosi: " + statistics.Max);







