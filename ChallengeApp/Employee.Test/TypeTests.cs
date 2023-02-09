namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void ChecksIfThereAreNoEmployeesSurnameIdentical()
        {
            // arrange
            string surname1 = "Kamila";
            string surname2 = "Karolina";
            string surname3 = "Michał";

            // act
         

            // assert
            Assert.AreNotEqual(surname1, surname2);
            Assert.AreNotEqual(surname1, surname3);
            Assert.AreNotEqual(surname2, surname3);
        }

        [Test]
        public void ChecksIfThereAreNoEmployeesAgeIdentical()
        {
            // arrange
            int age1 = 23;
            int age2 = 18;
            int age3 = 30;

            // act


            // assert
            Assert.AreNotEqual(age1, age2);
            Assert.AreNotEqual(age1, age3);
            Assert.AreNotEqual(age2, age3);
        }

        [Test]
        public void ChecksIfThereAreNoEmployeesAverageScoreIdentical()
        {
            // arrange
            float average1 = 5.4f;
            float average2 = 4.2f;
            float average3 = 7.6f;

            // act


            // assert
            Assert.AreNotEqual(average1, average2);
            Assert.AreNotEqual(average1, average3);
            Assert.AreNotEqual(average2, average3);
        }

        [Test]
        public void ChecksIfThereAreNoDuplicateEmployees()
        {
            // arrange
            var employee1 = GetEmployee("Kamila", "Kowalska", "23");
            var employee2 = GetEmployee("Karolina", "Nowa", "18");
            var employee3 = GetEmployee("Michał", "Kot", "30");

            // act


            // assert
            Assert.AreNotEqual(employee1, employee2);
            Assert.AreNotEqual(employee1, employee3);
            Assert.AreNotEqual(employee2, employee3);
        }
        private Employee GetEmployee(string name, string surname, string age)
        {
            return new Employee(name, surname, age);
        }
    }
}
