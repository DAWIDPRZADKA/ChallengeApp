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
            Assert.AreEqual(statistcis1.Min, 3);
            Assert.AreEqual(statistcis2.Min, 1);
            Assert.AreEqual(statistcis3.Min, 5);
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
            Assert.AreEqual(statistcis1.Max, 10);
            Assert.AreEqual(statistcis2.Max, 8);
            Assert.AreEqual(statistcis3.Max, 9);
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
            Assert.AreEqual(statistcis1.Average, 5.4F);
            Assert.AreEqual(statistcis2.Average, 4.2F);
            Assert.AreEqual(statistcis3.Average, 7.6F);
        }
    }
}