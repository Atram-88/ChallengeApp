
var name = "Marcin";
var sex = "male";
var age = 17;

if (sex == "female" && age < 30)
{
    Console.WriteLine("Kobieta ponizej 30 lat");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, ma lat 30");
}
else if (sex == "male" && age < 18)
{
    Console.WriteLine("Niepelnoletni mezczyzna");
}
else
{
    Console.WriteLine("Nie odneleziono osoby");
}


