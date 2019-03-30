using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Student
    {
        private string Name;
        public int Grade { get; set; }
        private Instructor Teacher;

        public Student(string Name, Instructor Teacher)
        {
            this.Name = Name;
            this.Teacher = Teacher;
        }

        public void PrintNameGradeTeacher()
        {
            System.Console.WriteLine("Student: " + this.Name);
            System.Console.WriteLine("Grade: " + this.Grade);
            this.Teacher.PrintNameCourse();
        }
    }
}
