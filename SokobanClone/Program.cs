using System;
using System.Collections.Generic;

namespace SokobanClone
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            IStudentsRepository studentsRepository = new StudentsFromDb();

            //var students = new List<Student>();

            Student student = new Student("Dog");
            Student student1 = new Student("Laura");
            Student student2 = new Student("Cat");
            Student student3 = new Student("Chungus");

            studentsRepository.AddStudent(student);
            studentsRepository.AddStudent(student1);
            studentsRepository.AddStudent(student2);
            studentsRepository.AddStudent(student3);

            var laura = studentsRepository.GetStudent("Laura");
            if (laura != null)
            {
                studentsRepository.RemoveStudent("Laura");
            }

            Console.WriteLine(studentsRepository);
        }
    }
}

// this is a code. Done :)

//game:
// - floor
// - wall 
// - storage location

//player: 
// - move up and down a cell
// - player cant walk into a wall
// - cant walk on crate if its pushed against a wall

//box:
// - cannot be pulled
// - can be pushed
// - cannot be pushed to wall or other box 
// - number of boxes equals the number of storage locations

//target:
// - some floor squares are marked as storage locations
// - must place all boxes there to complete a game

//floor (what does it have)
// - different color
// - coordinates

//wall (what does it have)
// - different color
// - coordinates
//👻


/*
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 */

