
namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void WhenNamesOfEmployeesAreTheSameButItsNotEqualAsAReferenceValue()
        {
            //Arrange
            Employee employee6 = GetName("Jacek");
            Employee employee7 = GetName("Jacek");

            //Act

            //Assert
            Assert.AreNotEqual(employee6, employee7);

            Employee GetName(string name)
            {
                return new Employee(name);
            }
        }
        [Test]
        public void WhenTwoStringsAreEqual()
        {
            //Arrange
            Employee employee6 = new Employee("Jacek");
            Employee employee7 = new Employee("Jacek");

            //Act

            //Assert
            Assert.AreEqual(employee6.Name, employee7.Name);

        }
        [Test]
        public void WhenTwoEmployeesAreNotEgualAsReferenceTypes()
        {
            //Arrange
            Employee employee6 = GetUser("Jacek", "Bula", 33);
            Employee employee7 = GetUser("Jacek", "Bula", 33);

            //Act

            //Assert
            Assert.AreNotEqual(employee6, employee7);

            Employee GetUser(string name, string surname, int age)
            {
                return new Employee(name, surname, age);
            }
        }
        [Test]
        public void WhenTwoSurnamesAreEqualAsAStrings()
        {
            //Arrange
            Employee employee6 = new Employee("Jacek", "Pacek", 30);
            Employee employee7 = new Employee("Jack", "Pacek", 30);

            //Act

            //Assert
            Assert.AreEqual(employee6.Surname, employee7.Surname);


        }
        [Test]
        public void WhenTwoValueTypesAreNotEqual()
        {
            //Arrange
            int age1 = 31;
            int age2 = 33;

            //Act

            //Assert
            Assert.AreNotEqual(age1, age2);
        }
        [Test]
        public void WhenTwoIntigerValuesAreTheSame()
        {
            //Arrange
            Employee employee6 = new Employee("Jacek", "Pacek", 30);
            Employee employee7 = new Employee("Jack", "Pacek", 30);

            //Act

            //Assert
            Assert.AreEqual(employee6.Age, employee7.Age);


        }


    }
}


