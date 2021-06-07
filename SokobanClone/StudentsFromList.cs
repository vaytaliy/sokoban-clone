using System;
using System.Collections.Generic;
using System.Text;

namespace SokobanClone
{
    class StudentsFromList : IStudentsRepository
    {
        public List<Student> Students { get; set; }
        public int Number { get; set; }

        public StudentsFromList()
        {
            Students = new List<Student>();
            Number = 5;
        }

        public Student GetStudent(string searchedStudentName)
        {
            foreach (Student student in Students)
            {
                if (student.Name == searchedStudentName)
                {
                    return student;
                }
            }

            return null;
        }

        public void AddStudent(Student newStudent)
        {
            foreach (Student student in Students)
            {
                if (student.Name == newStudent.Name)
                {
                    return;
                }
            }
            Students.Add(newStudent);
        }

        public void RemoveStudent(string studentName)
        {
            var foundStudent = GetStudent(studentName);

            if (foundStudent != null)
            {
                Students.Remove(foundStudent);
            }
        }

        public override string ToString()
        {
            var studentPrint = "";
            foreach (Student student in Students)
            {
                studentPrint += student.Name + ", ";
            }
            return studentPrint;
        }
    }
}
