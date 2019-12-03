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

      // Method call
      // using object name.
      // Sorts list.
      students.Sort();

      // Creates new student.
      Student newStudent = new Student() {

        Name = "Joe",
        GradeLevel = 2

      };

      // Method call
      // using binary search.
      int index = students.BinarySearch(newStudent);

      if(index < 0) {

        // Inserts item into the list.
        students.Insert(~index, newStudent);

      }

      // Outputs students
      // through each loop iteration.
      foreach(Student student in students) {

        Console.WriteLine($"{student.Name} is a in grade {student.GradeLevel}");

      }

      Console.ReadKey();

    }

  }

}
