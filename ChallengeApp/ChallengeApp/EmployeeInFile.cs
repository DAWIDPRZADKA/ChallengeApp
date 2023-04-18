namespace ChallengeApp
{
    internal class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";
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
                        case 'B':
                        case 'b':
                        case 'C':
                        case 'c':
                        case 'D':
                        case 'd':
                        case 'E':
                        case 'e':
                            writer.WriteLine(resultChar);
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
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average = statistics.Average / grades.Count;
            switch (statistics.Average)
            {
                case var average when average >= 100:
                    statistics.AverageLetter = 'a';
                    statistics.AverageLetter = 'a';
                    break;
                case var average when average >= 80:
                    statistics.AverageLetter = 'b';
                    statistics.AverageLetter = 'b';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'c';
                    statistics.AverageLetter = 'c';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'd';
                    statistics.AverageLetter = 'd';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'e';
                    statistics.AverageLetter = 'e';
                    break;
                default:
                    statistics.AverageLetter = 'f';
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

