
namespace MyProgram {

  // Class inherits IComparable interface.
  // Student can be comparared to other objects of type student.
  class Student : System.IComparable<Student> {

    // Declares properties.
    public string Name {get; set;}
    public int GradeLevel {get; set;}

    // Implements IComparable interface.
    public int CompareTo(Student that) {

      // Sorts student by Name.
      int result = this.Name.CompareTo(that.Name);

      if(result == 0) {

        result = this.GradeLevel.CompareTo(that.GradeLevel);

      }

      // Returns result.
      return result;

    }

  }

}
