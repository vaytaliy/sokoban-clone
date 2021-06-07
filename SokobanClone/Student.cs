using System;
using System.Collections.Generic;
using System.Text;

namespace SokobanClone
{
    class Student
    {
        public string Name { get; set; }
        public List<int> Grades { get; set; }
        public float AverageGrade { get; set; } = 0.0f;
        public bool CanProceedToExams { get; set; } = false;

        public Student(string name)
        {
            Name = name;
            Grades = new List<int>();
        }

        public void AddGrade(int grade)
        {
            if (grade <= 10 && grade >= 0)
            {
                Grades.Add(grade);
            }
        }

        //write CalculateAverageGrade method :)
        // It does 2 things:
        // 1. calculates average
        // 2. determines if student is accepted for exams. The average score should be more than 5
        // it should modify AverageGrade, CanProceedToExams
        public void CalculateAverageGrade()
        {
            //TODO:
            //1. count items in list
            //2. count sum of all items
            //3. divide to get average
            //4. compare with minimum allowed score
            var x = Grades.Count;
            int sum = 0;
            for (int i = 0; i < x; i++)
            {
                sum += Grades[i];
            }
            float average = (float)sum / x;
            if (average >= 5)
            {
                CanProceedToExams = true;
            }
            else
            {
                CanProceedToExams = false;
            }
        }
    }
}
