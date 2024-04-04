
using System.ComponentModel.Design;

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
            if (float.TryParse(number, out float result))
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

        public void AddScore(char letter)
        {    
            switch(letter)
            {
                case 'A':
                case 'a':
                    this.score.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.score.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.score.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.score.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.score.Add(20);
                    break;
                default:
                    Console.WriteLine("Wrong Letters");
                    break;
            }
        }


        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;
            statistics.Average = 0;

            foreach (float grade in this.score)
            {
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Average = this.score.Sum();
            }
            statistics.Average = statistics.Average / this.score.Count;

            switch(statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;

            }
            return statistics;
        }
    }
}
 




