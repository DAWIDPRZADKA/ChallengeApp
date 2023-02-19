namespace ChallengeApp.Tests
{
    public class StatisticsTests
    {
        [Test]
        public void ChecksIfThereAreMinValueForEmployeeCorrect()
        {
            // arrange
            var Employee1 = new Employee("Kamila", "Kowalska", "23");
            var Employee2 = new Employee("Karolina", "Nowa", "18");
            var Employee3 = new Employee("Michał", "Kot", "30");

            // act
            Employee1.AddGrade(10);
            Employee1.AddGrade(4);
            Employee1.AddGrade(6);
            Employee1.AddGrade(4);
            Employee1.AddGrade(3);

            Employee2.AddGrade(1);
            Employee2.AddGrade(3);
            Employee2.AddGrade(2);
            Employee2.AddGrade(8);
            Employee2.AddGrade(7);

            Employee3.AddGrade(5);
            Employee3.AddGrade(6);
            Employee3.AddGrade(9);
            Employee3.AddGrade(9);
            Employee3.AddGrade(9);

            var statistcis1 = Employee1.GetStatistics();
            var statistcis2 = Employee2.GetStatistics();
            var statistcis3 = Employee3.GetStatistics();

            // assert
            Assert.AreEqual(3, statistcis1.Min);
            Assert.AreEqual(1, statistcis2.Min);
            Assert.AreEqual(5, statistcis3.Min);
        }

        [Test]
        public void ChecksIfThereAreMaxValueForEmployeeCorrect()
        {
            // arrange
            var Employee1 = new Employee("Kamila", "Kowalska", "23");
            var Employee2 = new Employee("Karolina", "Nowa", "18");
            var Employee3 = new Employee("Michał", "Kot", "30");

            // act
            Employee1.AddGrade(10);
            Employee1.AddGrade(4);
            Employee1.AddGrade(6);
            Employee1.AddGrade(4);
            Employee1.AddGrade(3);

            Employee2.AddGrade(1);
            Employee2.AddGrade(3);
            Employee2.AddGrade(2);
            Employee2.AddGrade(8);
            Employee2.AddGrade(7);

            Employee3.AddGrade(5);
            Employee3.AddGrade(6);
            Employee3.AddGrade(9);
            Employee3.AddGrade(9);
            Employee3.AddGrade(9);

            var statistcis1 = Employee1.GetStatistics();
            var statistcis2 = Employee2.GetStatistics();
            var statistcis3 = Employee3.GetStatistics();

            // assert
            Assert.AreEqual(10, statistcis1.Max);
            Assert.AreEqual(8, statistcis2.Max);
            Assert.AreEqual(9, statistcis3.Max);
        }

        [Test]
        public void ChecksIfThereAreAverageValueForEmployeeCorrect()
        {
            // arrange
            var Employee1 = new Employee("Kamila", "Kowalska", "23");
            var Employee2 = new Employee("Karolina", "Nowa", "18");
            var Employee3 = new Employee("Michał", "Kot", "30");

            // act
            Employee1.AddGrade(10);
            Employee1.AddGrade(4);
            Employee1.AddGrade(6);
            Employee1.AddGrade(4);
            Employee1.AddGrade(3);

            Employee2.AddGrade(1);
            Employee2.AddGrade(3);
            Employee2.AddGrade(2);
            Employee2.AddGrade(8);
            Employee2.AddGrade(7);

            Employee3.AddGrade(5);
            Employee3.AddGrade(6);
            Employee3.AddGrade(9);
            Employee3.AddGrade(9);
            Employee3.AddGrade(9);

            var statistcis1 = Employee1.GetStatistics();
            var statistcis2 = Employee2.GetStatistics();
            var statistcis3 = Employee3.GetStatistics();

            // assert
            Assert.AreEqual(5.4F, statistcis1.Average);
            Assert.AreEqual(4.2F, statistcis2.Average);
            Assert.AreEqual(7.6F, statistcis3.Average);
        }
    }
}