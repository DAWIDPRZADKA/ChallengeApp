namespace ChallengeApp
{
    public interface IEmployee
    {
        string Name { get; }

        string Surname { get; }

        string Position { get; }

        string Age { get; }

        void AddGrade(float grade);

        void AddGrade(string grade);

        void AddGrade(double grade);

        void AddGrade(int grade);

        void AddGrade(long grade);

        void AddGrade(decimal grade);

        void AddGrade(char grade);

        void AddGrade();

        Statistics GetStatistics();
    }
}
