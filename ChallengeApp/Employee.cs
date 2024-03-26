
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


        public Statistics GetStatisticsWithForeach()
        {
            var statistics1 = new Statistics();
            statistics1.Min = float.MaxValue;
            statistics1.Max = float.MinValue;
            statistics1.Average = 0;

            foreach (float grade in this.score)
            {
                statistics1.Min = Math.Min(statistics1.Min, grade);
                statistics1.Max = Math.Max(statistics1.Max, grade);
                statistics1.Average = this.score.Sum();
            }
            statistics1.Average = statistics1.Average / this.score.Count;
            return statistics1;
        }

        public Statistics GetStatisticsWithFor()
        {
            var statistics2 = new Statistics();
            statistics2.Min = float.MaxValue;
            statistics2.Max = float.MinValue;
            statistics2.Average = 0;
            int i = 0;

            for (i = 0; i < this.score.Count;)
            {
                statistics2.Min = Math.Min(statistics2.Min, this.score[i]);
                statistics2.Max = Math.Max(statistics2.Max, this.score[i]);
                statistics2.Average += this.score[i];
                i++;
            }
            statistics2.Average = statistics2.Average / this.score.Count;
            return statistics2;

        }
        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics3 = new Statistics();
            statistics3.Min = float.MaxValue;
            statistics3.Max = float.MinValue;
            statistics3.Average = 0;
            int i = 0;
            do
            {
                statistics3.Min = Math.Min(statistics3.Min, this.score[i]);
                statistics3.Max = Math.Max(statistics3.Max, this.score[i]);
                statistics3.Average += this.score[i];
                i++;
            }
            while (i < this.score.Count);

            statistics3.Average /= this.score.Count;
            return statistics3;

        }
        public Statistics GetStatisticsWithWhile()
        {
            var statistics4 = new Statistics();
            statistics4.Min = float.MaxValue;
            statistics4.Max = float.MinValue;
            statistics4.Average = 0;
            int i = 0;

            while (i < this.score.Count)
            {
                statistics4.Min = Math.Min(statistics4.Min, this.score[i]);
                statistics4.Max = Math.Max(statistics4.Max, this.score[i]);
                statistics4.Average += this.score[i];
                i++;  
            }
            statistics4.Average /= this.score.Count;
            return statistics4;
        }
    }
}
 




