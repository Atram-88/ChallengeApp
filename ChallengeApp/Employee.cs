
namespace ChallengeApp
{
    public class Employee
    {
        private List<float> score = new List<float>();

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
        public float Result
        {
            get
            {
                return this.score.Sum();
            }
        }
        //Metody:
        //metoda dodajaca punkty do listy
        public void AddScore(float number)
        {
            if (number >= 0 && number <= 100)
            {
                this.score.Add(number);
            }
            else
            {
                Console.WriteLine("invalid grade value");
            }
        }
        
        public void AddScore(string number)
        {
            if(float.TryParse(number, out float result))
            {
                this.AddScore(result);
            }
            else
            {
                Console.WriteLine("String is not a float");
            }
        }
        public void AddScore(double number)
        {
            float valueInFloat = (float)number;
            this.AddScore(valueInFloat);
        }
        public void AddScore(int number)
        {
            float IntInFloat = (float)number;
            this.AddScore(IntInFloat);
        }
        public void AddScore(long number)
        {
            float LongInFloat = (float)number;
            this.AddScore(LongInFloat);
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
