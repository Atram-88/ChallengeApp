using System.Net.NetworkInformation;

namespace ChallengeApp
{
    public class Employee
    {
        private List<int> score = new List<int>();

        //konstruktor:
        public Employee(string name)
        {
            this.Name = name;
        }
        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;

        }
        //propercje:
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }

        //Metody:
        //metoda zwracajaca wynik:
        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }
        //metoda dodajaca punkty do listy
        public void AddScore(int number)
        {
            this.score.Add(number);
        }

        //metoda zwracajaca model Statistics (referencje/obiekt)
        public Statistics GetStatistics()
        {
            //implementacja metody w taki sposob zeby zwrocila odpowiednio wypelniony model Statistics
            //przygotowanie obiektu:
            var statistics = new Statistics();

            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;
            statistics.Average = 0;

            foreach (var score in this.score) 
            {
                statistics.Min = Math.Min(statistics.Min, score);
                statistics.Max = Math.Max(statistics.Max, score);
                statistics.Average += score;
            }

            statistics.Average = statistics.Average / this.score.Count();


            return statistics;

        }
       
    }
}
