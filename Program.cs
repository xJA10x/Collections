using System;
using System.Collections.Generic;

namespace MyProgram {

  class Program {

    public  static void Main(string[] args) {

      // Builds object from the Students class
      // in order to have access to variables and methods.

      // Builds list.
      List<Student> students = new List<Student> {

        // Creates new students.
        new Student() {

          Name = "Sally",
          GradeLevel = 3

        },
        new Student() {

          Name = "Bod",
          GradeLevel = 2

        },
        new Student() {

          Name = "Sally",
          GradeLevel = 2

        }

      };

      // Builds object from the SchoolRolls class.
      SchoolRoll schoolRoll = new SchoolRoll();
      // Method call using object name.
      // Takes one parameter,
      // the list of students.
      schoolRoll.AddStudents(students);

      // Removes student.
      schoolRoll.Students.RemoveAt(0);
      // Sorts students.
      schoolRoll.Students.Sort();

      // Adds students.
      schoolRoll.Students.AddRange(students);


      // Outputs students
      // through each loop iteration
      // by accessing property with object name
      foreach(Student student in schoolRoll.Students) {

        Console.WriteLine($"{student.Name} is a in grade {student.GradeLevel}");

      }

      Console.ReadKey();

    }

  }

}
