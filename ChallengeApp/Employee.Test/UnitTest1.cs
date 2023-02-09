namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollectFiveScores_ShouldReturnCorrectSumAsResult()
        {
            // arrange
            var employee = new Employee("Kamila", "Kowalska", "23");
            employee.AddScore(10);
            employee.AddScore(4);
            employee.AddScore(6);
            employee.AddScore(4);
            employee.AddScore(3);

            // act
            var result = employee.Result;

            // assert        
            Assert.AreEqual(27, result);
        }
    }
}