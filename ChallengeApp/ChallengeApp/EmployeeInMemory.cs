﻿namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        private List<float> grades = new List<float>();
        public EmployeeInMemory(string name, string surname, string position, string age)
            : base(name, surname, position, age)
        {
        }
        public override void AddGrade(float grade)
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

        public override void AddGrade(string grade)
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
                if (float.TryParse(grade, out float result))
                {
                    this.AddGrade(result);
                }
                else
                {
                    throw new Exception("Podana wartość nie jest floatem");
                }
            }
        }

        public override void AddGrade(double grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public override void AddGrade(int grade)
        {
            this.AddGrade((float)grade);
        }

        public override void AddGrade(long grade)
        {
            this.AddGrade((float)grade);
        }

        public override void AddGrade(decimal grade)
        {
            this.AddGrade((float)grade);
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;

                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;

                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;

                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;

                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;

                default:
                    throw new Exception("Ocena - przypisana zła litera");
            }
        }

        public override void AddGrade()
        {
            throw new Exception("Musisz nadusić Enter aby podać wartość oceny");
        }

        public override Statistics GetStatistics()
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