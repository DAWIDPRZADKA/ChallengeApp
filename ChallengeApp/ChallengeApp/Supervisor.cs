namespace ChallengeApp
{
    internal class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();

        public Supervisor(string name, string surname, string age, string position)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Position = position;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Age { get; private set; }
        public string Position { get; private set; }
        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Niepoprawna wartość oceny" + " " + this.Name + " " + this.Surname);
            }
        }
        public void AddGrade(string grade)
        {
            if (grade.Length == 1)
            {
                char resultChar = grade[0];
                switch (resultChar)
                {
                    case '6':
                    case '5':
                    case '4':
                    case '3':
                    case '2':
                    case '1':

                        this.AddGrade(resultChar);
                        break;
                    default:

                        if (float.TryParse(grade, out float result))
                        {
                            this.AddGrade(result);
                        }
                        else
                        {
                            throw new Exception("String nie jest floatem");
                        }
                        break;
                }
            }
            else
            {
                if (grade.Length == 2)
                {
                    
                    string resultString = grade;
                    switch (resultString)
                    {
                        //6
                        case "6-" or "-6":
                            this.grades.Add(95);
                            break;
                        //5
                        case "5+" or "+5":
                            this.grades.Add(85);
                            break;
                        case "5-" or "-5":
                            this.grades.Add(75);
                            break;
                        //4
                        case "4+" or "+4":
                            this.grades.Add(65);
                            break;
                        case "4-" or "-4":
                            this.grades.Add(55);
                            break;
                        //3
                        case "3+" or "+3":
                            this.grades.Add(45);
                            break;
                        case "3-" or "-3":
                            this.grades.Add(35);
                            break;
                        //2
                        case "2+" or "+2":
                            this.grades.Add(25);
                            break;
                        case "2-" or "-2":
                            this.grades.Add(15);
                            break;
                        //1
                        case "1+" or "+1":
                            this.grades.Add(5);
                            break;
                        default:

                            if (float.TryParse(grade, out float result))
                            {
                                this.AddGrade(result);
                            }
                            else
                            {
                                throw new Exception("String nie jest floatem");
                            }
                            break;
                    }
                }
            }
        }
        public void AddGrade(double grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }
        public void AddGrade(int grade)
        {
            this.AddGrade((float)grade);
        }
        public void AddGrade(long grade)
        {
            this.AddGrade((float)grade);
        }
        public void AddGrade(decimal grade)
        {
            this.AddGrade((float)grade);
        }
        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case '6':
                    this.grades.Add(100);
                    break;

                case '5':
                    this.grades.Add(80);
                    break;

                case '4':
                    this.grades.Add(60);
                    break;

                case '3':
                    this.grades.Add(40);
                    break;

                case '2':
                    this.grades.Add(20);
                    break;
                case '1':
                    this.grades.Add(0);
                    break;

                default:
                    throw new Exception("Przypisana zła wartość oceny");
            }
        }
        public void AddGrade()
        {
            throw new Exception("Musisz nadusić Enter aby podać wartość oceny");
        }
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average = statistics.Average / this.grades.Count;
            switch (statistics.Average)
            {
                case var average when average >= 100:
                    statistics.AverageLetter = 'A';
                    statistics.AverageLetter = 'a';
                    break;
                case var average when average >= 80:
                    statistics.AverageLetter = 'B';
                    statistics.AverageLetter = 'b';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'C';
                    statistics.AverageLetter = 'c';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'D';
                    statistics.AverageLetter = 'd';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'E';
                    statistics.AverageLetter = 'e';
                    break;
                default:
                    statistics.AverageLetter = 'F';
                    statistics.AverageLetter = 'e';
                    break;
            }
            if (grades.Count == 0)
            {
                statistics.Max = 0;
                statistics.Min = 0;
                statistics.Average = 0;
            }
            return statistics;

        }
    }
}
