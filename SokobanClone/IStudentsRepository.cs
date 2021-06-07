using System.Collections.Generic;

namespace SokobanClone
{
    interface IStudentsRepository
    {
        int Number { get; set; }
        List<Student> Students { get; set; }

        void AddStudent(Student newStudent);
        Student GetStudent(string searchedStudentName);
        void RemoveStudent(string studentName);
        string ToString();
    }
}