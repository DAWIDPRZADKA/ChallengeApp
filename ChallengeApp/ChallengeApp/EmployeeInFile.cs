namespace ChallengeApp
{
    internal class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";

        public override event GradeAddedDelegate GradeAdded;
        public EmployeeInFile(string name, string surname, string position, string age) : base(name, surname, position, age)
        {
        }

        public override void AddGrade(float grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                if (grade >= 0 && grade <= 100)
                {
                    writer.WriteLine(grade);

                    if (GradeAdded != null)
                    {
                        GradeAdded(this, new EventArgs());
                    }
                }
                else
                {
                    throw new Exception("Niepoprawna wartość oceny" + " " + this.Name + " " + this.Surname);
                }
            }
        }

        public override void AddGrade(string grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                if (grade.Length == 1)
                {
                    char resultChar = grade[0];
                    switch (resultChar)
                    {
                        case 'A':
                        case 'a':
                            writer.WriteLine(100);
                            break;

                        case 'B':
                        case 'b':
                            writer.WriteLine(80);
                            break;

                        case 'C':
                        case 'c':
                            writer.WriteLine(60);
                            break;

                        case 'D':
                        case 'd':
                            writer.WriteLine(40);
                            break;

                        case 'E':
                        case 'e':
                            writer.WriteLine(20);
                            break;
                        default:

                            if (float.TryParse(grade, out float result))
                            {
                                writer.WriteLine(result);
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
                    if (float.TryParse(grade, out float result))
                    {
                        writer.WriteLine(result);
                    }
                    else
                    {
                        throw new Exception("Podana wartość nie jest floatem");
                    }
                }
            }
        }

        public override void AddGrade(double grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                float result = (float)grade;
                writer.WriteLine(result);
            }
        }

        public override void AddGrade(int grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine((float)grade);
            }
        }

        public override void AddGrade(long grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine((float)grade);
            }
        }

        public override void AddGrade(decimal grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine((float)grade);
            }
        }

        public override void AddGrade(char grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                switch (grade)
                {
                    case 'A':
                    case 'a':
                        writer.WriteLine(100);
                        break;

                    case 'B':
                    case 'b':
                        writer.WriteLine(80);
                        break;

                    case 'C':
                    case 'c':
                        writer.WriteLine(60);
                        break;

                    case 'D':
                    case 'd':
                        writer.WriteLine(40);
                        break;

                    case 'E':
                    case 'e':
                        writer.WriteLine(20);
                        break;

                    default:
                        throw new Exception("Ocena - przypisana zła litera");
                }
            }
        }

        public override void AddGrade()
        {
            throw new Exception("Musisz nadusić Enter aby podać wartość oceny");
        }

        public override Statistics GetStatistics()
        {
            var gradesFromFile = this.ReadGradesFromFile();
            var resultFromFile = this.CountStatistics(gradesFromFile);
            return resultFromFile;
        }

        private List<float> ReadGradesFromFile()
        {
            var grades = new List<float>();
            if (File.Exists($"{fileName}"))
            {
                using (var reader = File.OpenText($"{fileName}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return grades;
        }

        private Statistics CountStatistics(List<float> grades)
        {
            var statistics = new Statistics();
            foreach (var grade in ReadGradesFromFile())
            {
                statistics.AddGrade(grade);
            }
            return statistics;
        }
    }
}

