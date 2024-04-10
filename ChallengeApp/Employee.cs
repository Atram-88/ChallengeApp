


namespace ChallengeApp
{
    public class Employee : Person
    {
        private List<float> score = new List<float>();

        //konstruktor:
        public Employee(string name, string surname, char sex, int age)
            :base(name, surname, sex)
        {   
            this.Age = age;
        }
        //propercje:
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
                throw new Exception ("invalid grade value");
            }
        }

        public void AddScore(string value)
        {
            if (float.TryParse(value, out float result))
            {
                this.AddScore(result);
            }
            else if (char.TryParse(value, out char resultChar))
            {
                this.AddScore(resultChar);
            }
            else
            {
                throw new Exception ("String is not a float");
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
                    throw new Exception ("Wrong Letter");    
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
 




