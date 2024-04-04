namespace ChallengeApp.Tests
{
    public class Tests
    {

        [Test]
        public void WhenTwoEmployeesTheSameResultsAreEqual()
        {
            //Arrange
            Employee employee6 = new Employee("Jacek", "Pacek", 30);
            Employee employee7 = new Employee("Jack", "Pacek", 29);
            employee6.AddScore(3);
            employee7.AddScore(3);


            //Act
            var result6 = employee6.Result;
            var result7 = employee7.Result;


            //Assert
            Assert.AreEqual(result6, result7);

        }

        [Test]
        public void WhenNamesAreNotEqual()
        {
            //Arrange
            Employee employee6 = new Employee("Jacek", "Pacek", 30);
            Employee employee7 = new Employee("Marek", "Pacek", 29);

            //Act
            var name6 = employee6.Name;
            var name7 = employee7.Name;

            //Assert
            Assert.AreNotEqual(name6, name7);

        }
        [Test]
        public void WhenAgesAreNotEqual()
        {
            //Arrange
            Employee employee6 = new Employee("Jacek", "Pacek", 30);
            Employee employee7 = new Employee("Marek", "Pacek", 29);

            //Act
            var age6 = employee6.Age;
            var age7 = employee7.Age;

            //Assert
            Assert.AreNotEqual(age6, age7);

        }
        [Test]
        public void StatisticsTestWhenMinValueIsEqualThenTestIsCorrect()
        {
            //Arrange
            Employee employee1 = new Employee("Jacek", "Pacek", 30);
            employee1.AddScore(1);
            employee1.AddScore(10);
            employee1.AddScore(7);
            employee1.AddScore(2);
            employee1.AddScore(8);

            //Act
            var statistics = employee1.GetStatistics();

            //Assert
            Assert.AreEqual(statistics.Min, 1);

        }
        [Test]
        public void StatisticsTestWhenMaxValueIsEqualThenTestIsCorrect()
        {
            //Arrange
            Employee employee1 = new Employee("Jacek", "Pacek", 30);
            employee1.AddScore(1);
            employee1.AddScore(10);
            employee1.AddScore(7);
            employee1.AddScore(2);
            employee1.AddScore(8);

            //Act
            var statistics = employee1.GetStatistics();

            //Assert
            Assert.AreEqual(statistics.Max, 10);

        }
        [Test]
        public void StatisticsTestWhenAverageValueIsEqualThenTestIsCorrect()
        {
            //Arrange
            Employee employee1 = new Employee("Jacek", "Pacek", 30);
            employee1.AddScore(1);
            employee1.AddScore(10);
            employee1.AddScore(7);
            employee1.AddScore(2);
            employee1.AddScore(8);

            //Act
            var statistics = employee1.GetStatistics();

            //Assert
            Assert.AreEqual(Math.Round(statistics.Average, 2), Math.Round(5.599, 2));

        }
        [Test]
        public void StatisticsTestWhenValueWithStringsIsEqualThenTestIsCorrect()
        {
            //Arrange
            Employee employee1 = new Employee("Jacek", "Pacek", 30);
            employee1.AddScore('a');
            employee1.AddScore('B');
            employee1.AddScore('c');
            employee1.AddScore('d');
            employee1.AddScore('E');

            //Act
            var statistics = employee1.GetStatistics();

            //Assert
            Assert.AreEqual(statistics.Average, 60);

        }
        [Test]
        public void StatisticsTestWhenProperCharAsAverageLetterThenTestIsCorrect()
        {
            //Arrange
            Employee employee1 = new Employee("Jacek", "Pacek", 30);
            employee1.AddScore('a');
            employee1.AddScore('B');
            employee1.AddScore('c');
            employee1.AddScore('d');
            employee1.AddScore('E');

            //Act
            var statistics = employee1.GetStatistics();

            //Assert
            Assert.AreEqual(statistics.AverageLetter, 'B');

        }

        [Test]
        public void StatisticsTestWhenScoresAreParsableThenTestIsCorrect()
        {
            //Arrange
            Employee employee1 = new Employee("Jacek", "Pacek", 30);
            employee1.AddScore(11.5);
            employee1.AddScore(5);
            employee1.AddScore(3.5);
            employee1.AddScore('d');
            employee1.AddScore('E');

            //Act
            var Suma = employee1.Result;
            
            //Assert
            Assert.AreEqual(Suma, 80);

        }

        [Test]
        public void StatisticsTestWhenSomeScoresAreNotParsableThenTestIsCorrect()
        {
            //Arrange
            Employee employee1 = new Employee("Jacek", "Pacek", 30);
            employee1.AddScore("Marek");
            employee1.AddScore(5);
            employee1.AddScore('J');
            employee1.AddScore('d');
            employee1.AddScore('E');

            //Act
            var Suma = employee1.Result;

            //Assert
            Assert.AreEqual(Suma, 65);

        }
    }
}