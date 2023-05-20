namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);
        
        public abstract event GradeAddedDelegate GradeAdded;

        public EmployeeBase(string name, string surname, string position, string age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Position = position;
            this.Age = age;
        }
        public string Name { get; private set; }

        public string Surname { get; private set; }

        public string Position { get; private set; }

        public string Age { get; private set; }

        public abstract void AddGrade(float grade);

        public abstract void AddGrade(string grade);

        public abstract void AddGrade(double grade);

        public abstract void AddGrade(int grade);

        public abstract void AddGrade(long grade);

        public abstract void AddGrade(decimal grade);

        public abstract void AddGrade(char grade);

        public abstract void AddGrade();

        public abstract Statistics GetStatistics();
    }
}
