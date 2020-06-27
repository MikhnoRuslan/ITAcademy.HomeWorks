using System;

namespace Task1
{
    class StudentAndTeacherTest
    {
        private const int AgeStudent = 21;
        private const int AgeTeacher = 30;
        private const string _Students = "Students";
        private const string _Teacher = "Teacher";

        static void Main()
        {
            Console.WriteLine($"Person:");
            Person person = new Person();
            person.PrintData();

            Console.WriteLine($"Student:");
            Student student = new Student(AgeStudent, _Teacher);
            student.PrintData();

            Console.WriteLine($"Teacher:");
            Teacher teacher = new Teacher(AgeTeacher, _Students);
            teacher.PrintData();
        }
    }
}
