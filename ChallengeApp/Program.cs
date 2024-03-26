

using ChallengeApp;


Employee employee1 = new Employee("Jacek", "Pacek", 32);
Employee employee2 = new Employee("Paul", "Kraul", 33);
Employee employee3 = new Employee("Mark", "Markson", 46);

employee1.AddScore("5");
employee1.AddScore(10);
employee1.AddScore("5");
employee1.AddScore(2);
employee1.AddScore("8");

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


foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        empWithMaxResult = employee;
    }
}

//Console.WriteLine("Najwieksza liczbe punktow zdobywa: " + empWithMaxResult.Name + " " + empWithMaxResult.Surname + " lat " + empWithMaxResult.Age);
//Console.WriteLine("Wynik wynosi: " + maxResult);




var statistics1 = employee1.GetStatisticsWithForeach();
Console.WriteLine($"Minimalna ocena pracownika to: {statistics1.Min}");
Console.WriteLine($"Maksymalna ocena pracownika to: {statistics1.Max}");
Console.WriteLine($"Wartosc srednia z ocen pracownika to: {statistics1.Average:N2}");
Console.WriteLine(" ");

var statistics2 = employee1.GetStatisticsWithFor();
Console.WriteLine($"Minimalna ocena pracownika to: {statistics2.Min}");
Console.WriteLine($"Maksymalna ocena pracownika to: {statistics2.Max}");
Console.WriteLine($"Wartosc srednia z ocen pracownika to: {statistics2.Average:N2}");
Console.WriteLine(" ");

var statistics3 = employee1.GetStatisticsWithDoWhile();
Console.WriteLine($"Minimalna ocena pracownika to: {statistics3.Min}");
Console.WriteLine($"Maksymalna ocena pracownika to: {statistics3.Max}");
Console.WriteLine($"Wartosc srednia z ocen pracownika to: {statistics3.Average:N2}");
Console.WriteLine(" ");

var statistics4 = employee1.GetStatisticsWithWhile();
Console.WriteLine($"Minimalna ocena pracownika to: {statistics4.Min}");
Console.WriteLine($"Maksymalna ocena pracownika to: {statistics4.Max}");
Console.WriteLine($"Wartosc srednia z ocen pracownika to: {statistics4.Average:N2}");







