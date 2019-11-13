using System;
using System.Collections.Generic;

namespace Inclass2Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("A01083110", "Ming", "Wang");
            Student student2 = new Student("A01083111", "Alex", "Zhang");
            Student student3 = new Student("A01083112", "Kimo", "Liang");
            List<Student> students = new List<Student>();
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            Section php = new Section("3501", "PHP", students);
            Grade grade1 = new Grade(student1, 96);
            Grade grade2 = new Grade(student2, 97);
            Grade grade3 = new Grade(student2, 97);
            List<Grade> grades = new List<Grade>();
            grades.Add(grade1);
            grades.Add(grade2);
            grades.Add(grade3);
            Assignment ass1 = new Assignment("PHP first assignment",php,100,grades);
            Printer.PrintStudentNames(php);
            Printer.PrintAssignmentGrades(ass1);


        }
    }
}
