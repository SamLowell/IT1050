using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor john = new Instructor("John", "Doe", "English");
            Instructor mike = new Instructor("Mike", "Smith", "Math");
            Student jane = new Student("Jane", john);
            Student joe = new Student("Joe", john);
            Student melissa = new Student("Melissa", mike);
            Student matt = new Student("Matt", mike);

            john.setStudentGrade(jane, 95);
            john.setStudentGrade(joe, 85);
            mike.setStudentGrade(melissa, 90);
            mike.setStudentGrade(matt, 92);

            jane.PrintNameGradeTeacher();
            joe.PrintNameGradeTeacher();
            melissa.PrintNameGradeTeacher();
            matt.PrintNameGradeTeacher();

            System.Console.ReadKey();
        }
    }
}
