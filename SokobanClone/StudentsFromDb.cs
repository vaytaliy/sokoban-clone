using System;
using System.Collections.Generic;
using System.Text;

namespace SokobanClone
{
    class StudentsFromDb : IStudentsRepository
    {
        public int Number { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Student> Students { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AddStudent(Student newStudent)
        {
            throw new NotImplementedException();
        }

        public Student GetStudent(string searchedStudentName)
        {
            throw new NotImplementedException();
        }

        public void RemoveStudent(string studentName)
        {
            throw new NotImplementedException();
        }
    }
}
