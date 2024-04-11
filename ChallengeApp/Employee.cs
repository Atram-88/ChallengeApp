


namespace ChallengeApp
{
    public class Employee : Person
    {
        private List<float> grade = new List<float>();

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
                return this.grade.Sum();
            }
        }
        //Metody:
        //metoda dodajaca punkty do listy
        public void AddGrade(float number)
        {
            if (number >= 0 && number <= 100)
            {
                this.grade.Add(number);
            }
            else
            {
                throw new Exception ("invalid grade value");
            }
        }

        public void AddGrade(string value)
        {
            if (float.TryParse(value, out float result))
            {
                this.AddGrade(result);
            }
            else if (char.TryParse(value, out char resultChar))
            {
                this.AddGrade(resultChar);
            }
            else
            {
                throw new Exception ("String is not a float");
            }
        }
        public void AddGrade(double number)
        {
            float valueInFloat = (float)number;
            this.AddGrade(valueInFloat);
        }
        public void AddGrade(int number)
        {
            float IntInFloat = (float)number;
            this.AddGrade(IntInFloat);
        }
        public void AddGrade(long number)
        {
            float LongInFloat = (float)number;
            this.AddGrade(LongInFloat);
        }

        public void AddGrade(char letter)
        {    
            switch(letter)
            {
                case 'A':
                case 'a':
                    this.grade.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grade.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grade.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grade.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grade.Add(20);
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

            foreach (float grade in this.grade)
            {
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Average = this.grade.Sum();
            }
            statistics.Average = statistics.Average / this.grade.Count;

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
 




