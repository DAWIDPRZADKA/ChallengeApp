namespace ChallengeApp.Tests
{
    public class StatisticsTests
    {
        [Test]
        public void ChecksIfThereAreMinValueForEmployeeCorrect()
        {
            // arrange
            var Employee1 = new EmployeeInFile("Kamila", "Kowalska", "23", "Constructor");
            var Employee2 = new EmployeeInFile("Karolina", "Nowa", "18", "Secretary");
            var Employee3 = new EmployeeInFile("Michał", "Kot", "30", "Manager");

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
            var Employee1 = EmployeeInFile("Kamila", "Kowalska", "23", "Constructor");
            var Employee2 = EmployeeInFile("Karolina", "Nowa", "18", "Secretary");
            var Employee3 = EmployeeInFile("Michał", "Kot", "30", "Manager");

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
            var Employee1 = EmployeeInFile("Kamila", "Kowalska", "23", "Constructor");
            var Employee2 = EmployeeInFile("Karolina", "Nowa", "18", "Secretary");
            var Employee3 = EmployeeInFile("Michał", "Kot", "30", "Manager");

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

        [Test]
        public void ChecksIfThereAreLetterGradeAverageCorrect()
        {
            // arrange
            var Employee1 = EmployeeInFile("Kamila", "Kowalska", "23", "Constructor");
            var Employee2 = EmployeeInFile("Karolina", "Nowa", "18", "Secretary");
            var Employee3 = EmployeeInFile("Michał", "Kot", "30", "Manager");

            // act
            Employee1.AddGrade('A');
            Employee1.AddGrade('B');
            Employee1.AddGrade('C');
            Employee1.AddGrade('D');
            Employee1.AddGrade('E');

            Employee2.AddGrade('A');
            Employee2.AddGrade('B');
            Employee2.AddGrade('A');
            Employee2.AddGrade('C');
            Employee2.AddGrade('A');

            Employee3.AddGrade('C');
            Employee3.AddGrade('E');
            Employee3.AddGrade('C');
            Employee3.AddGrade('D');
            Employee3.AddGrade('E');

            var statistcis1 = Employee1.GetStatistics();
            var statistcis2 = Employee2.GetStatistics();
            var statistcis3 = Employee3.GetStatistics();

            // assert
            Assert.AreEqual('c', statistcis1.AverageLetter);
            Assert.AreEqual('b', statistcis2.AverageLetter);
            Assert.AreEqual('d', statistcis3.AverageLetter);
        }
        [Test]
        public void ChecksIfThereAreLowercaseAndUppercaseLetterGradeAverageCorrect()
        {
            // arrange
            var Employee1 = EmployeeInFile("Kamila", "Kowalska", "23", "Constructor");
            var Employee2 = EmployeeInFile("Karolina", "Nowa", "18", "Secretary");
            var Employee3 = EmployeeInFile("Michał", "Kot", "30", "Manager");

            // act
            Employee1.AddGrade('A');
            Employee1.AddGrade('b');
            Employee1.AddGrade('c');
            Employee1.AddGrade('d');
            Employee1.AddGrade('E');

            Employee2.AddGrade('a');
            Employee2.AddGrade('B');
            Employee2.AddGrade('A');
            Employee2.AddGrade('c');
            Employee2.AddGrade('a');

            Employee3.AddGrade('c');
            Employee3.AddGrade('E');
            Employee3.AddGrade('c');
            Employee3.AddGrade('D');
            Employee3.AddGrade('e');

            var statistcis1 = Employee1.GetStatistics();
            var statistcis2 = Employee2.GetStatistics();
            var statistcis3 = Employee3.GetStatistics();

            // assert
            Assert.AreEqual('c', statistcis1.AverageLetter);
            Assert.AreEqual('b', statistcis2.AverageLetter);
            Assert.AreEqual('d', statistcis3.AverageLetter);
        }

        [Test]
        public void ChecksIfThereAreLowercaseAndUppercaseLetterGradeMinimumCorrect()
        {
            // arrange
            var Employee1 = EmployeeInFile("Kamila", "Kowalska", "23", "Constructor");

            // act
            Employee1.AddGrade('A');
            Employee1.AddGrade('b');
            Employee1.AddGrade('c');
            Employee1.AddGrade('d');
            Employee1.AddGrade('E');

            var statistcis1 = Employee1.GetStatistics();

            // assert
            Assert.AreEqual(20, statistcis1.Min);
        }

        [Test]
        public void ChecksIfThereAreLowercaseAndUppercaseLetterGradeMaximumCorrect()
        {
            // arrange
            var Employee1 = EmployeeInFile("Kamila", "Kowalska", "23", "Constructor");

            // act
            Employee1.AddGrade('A');
            Employee1.AddGrade('b');
            Employee1.AddGrade('c');
            Employee1.AddGrade('d');
            Employee1.AddGrade('E');

            var statistcis1 = Employee1.GetStatistics();

            // assert
            Assert.AreEqual(100, statistcis1.Max);
        }
    }
}