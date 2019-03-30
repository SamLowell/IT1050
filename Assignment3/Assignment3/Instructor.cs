namespace Assignment3
{
    class Instructor
    {
        private string FirstName;
        private string CourseName;
        private string LastName;

        public Instructor(string FirstName, string LastName, string CourseName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.CourseName = CourseName;
        }

        public void setStudentGrade(Student student, int Grade)
        {
            student.Grade = Grade;
        }

        public string fullName()
        {
            return this.FirstName + " " + this.LastName;    
        }

        public void PrintNameCourse()
        {
            System.Console.WriteLine("Instructor: " + this.fullName());
            System.Console.WriteLine("Course: " + this.CourseName);
            System.Console.WriteLine("");
        }

    }
}
