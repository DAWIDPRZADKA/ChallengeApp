using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname, string age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Age { get; private set; }

        public void AddGrade(float grade)
        {
            byte valueInByte = (byte)grade;
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("invalid grade value for" + " " + this.Name + " " + this.Surname);
            }
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float for" + " " + this.Name + " " + this.Surname);
            }
        }
        public void AddGrade(int grade)
        {
            this.AddGrade((float)grade);
        }
        public void AddGrade(double grade)
        {
            this.AddGrade((float)grade);
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

            return statistics;

        }
        public Statistics GetStatisticsWithForEach()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            var index = 0;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Average += this.grades[index];
                index++;
            }

            statistics.Average = statistics.Average / this.grades.Count;

            return statistics;
        }
        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            for (var index = 0; index < 100; index++)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Average += this.grades[index];
            }

            statistics.Average = statistics.Average / this.grades.Count;

            return statistics;
        }
        
        public Statistics GetStatisticsWithDoWhile()
            {
                var statistics = new Statistics();
                statistics.Average = 0;
                statistics.Max = float.MinValue;
                statistics.Min = float.MaxValue;

                var index = 0;

                do
                {
                    statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                    statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                    statistics.Average += this.grades[index];
                    index++;
                } while (index < this.grades.Count);

                statistics.Average = statistics.Average / this.grades.Count;
                return statistics;
            }
        public Statistics GetStatisticsWithWhile()
            {
                var statistics = new Statistics();
                statistics.Average = 0;
                statistics.Max = float.MinValue;
                statistics.Min = float.MaxValue;

                var index = 0;

                while (index < this.grades.Count)
                {
                    statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                    statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                    statistics.Average += this.grades[index];
                    index++;
                }

                statistics.Average = statistics.Average / this.grades.Count;
                return statistics;
            }
    }
 }
