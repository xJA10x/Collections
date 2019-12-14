using System.Collections.Generic;

namespace MyProgram {

  class SchollRoll {

    private List<Student> _students = new List<Student>();

    // Builds property that returns the student list.
    // It only has a getter,
    // because it is only a read only property.
    public IEnumerable<Student> Students {
      get {

        // Returns list of students.
        return _students;

      }
    }

    public void AddStudents(IEnumerable<Student> students) {

      _students.AddRange(students);

    }

  }

}
