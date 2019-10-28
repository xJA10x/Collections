/**************************************

How to sort a list

**************************************/

// Notes:

  // The list collection is a lot easier to use than an array.
  // adding or removing elements in a list is as easy as just calling
  // a method.

  // Generics are not specific to generic types.

  // The add method appends items to the end of the list.

  // The list collection is a wrapper around an array.

  // Each time the list runs out of room in the underlying array,
  // it creates a new array that's twice the size of the original array
  // and copies over all the items.

  // We can add items to the list without thinking about its capacity.

  // Adding or removing items from a list can be very slow.

  // The capacity always increases by 3.

  // An array is encapsulated inside of a List.

  // One of the reasons to sorting a list is to make search faster.
    // One of the ways to sorting a list is to called the sort() method
    // on that list.

  // Searching allows us to find an item in the list before we can retrieve or
  // remove it.
  // In order to find items faster in a list,
  // they list must be sorted.

using System;
using System.Collections.Generic;

namespace MyProgram {

  public class Sorting {

    public static void Main(String[] args) {

      // Outputs empty line.
      Console.WriteLine("");
      // Outputs to the console.
      Console.WriteLine("################# Running Program ####################");
      // Outputs empty line.
      Console.WriteLine("");

      // Creates list.
      List<string> students = new List<string>();

      // Adds elements to the list.
      students.Add("Sue");
      students.Add("Bill");
      students.Add("Allen");

      // method call.
      Console.WriteLine(students.Count);
      Console.WriteLine(students.Count-1);

      students.Add("Beth");
      students.Add("Mary");

      Console.WriteLine(students.Count);
      Console.WriteLine(students.Capacity);

      /*

        Declaring list

      */

      // Declaring list.
      List<string> studentsTwo = new List<string>(500);
      // Outputs to the console.
      Console.WriteLine(studentsTwo.Capacity);

      // Initializing list.
      List<string> studentsThree = new List<string>() {"Sue", "Bill", "Allen", "Beth", "Mary"};
      // Outputs to the console.
      Console.WriteLine(studentsThree.Capacity);

      // Second way of initializing list.
      // Passing collection to the constructor.
      List<string> studentsFour = new List<string>(studentsThree);
      // Outputs to the console.
      Console.WriteLine(studentsFour.Capacity);

      // Method call.
      // Converts list into an array.
      string[] studentArray = studentsThree.ToArray();
      // Outputs to the console.
      Console.WriteLine(studentArray);

      /*

        How to insert items in a list.

      */

      // Inserts items into the list.
      studentsThree.Insert(1, "Frank");
      // Removes item from the list.
      studentsThree.RemoveAt(2);

      // Loops through every elements
      // in the list through each loop iteration
      foreach(string student in studentsThree) {

        Console.WriteLine(student);

      }

      /**
         Using searching.
      **/

      // Removes item from the list.
      Console.WriteLine(studentsThree.Remove("Frank"));

      // Outputs empty line.
      Console.WriteLine("");
      // Outputs to the console.
      Console.WriteLine("################### Exiting Program ####################");
      // Outptus empty line.
      Console.WriteLine();

      // Allows user to press any key to exit program.
      Console.ReadKey();

    }

  }

}
