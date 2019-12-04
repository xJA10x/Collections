using System.Collections.Generic;

namespace MyProgram {

  class SchollRoll {

    private List<Student> _students = new List<Student>();

    public void AddStudents(IEnumerable<Student> students) {

      _students.AddRange(students);

    }

  }

}
