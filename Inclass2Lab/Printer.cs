using System;
using System.Collections.Generic;
using System.Text;

namespace Inclass2Lab
{
    public class Printer
    {
        public static void PrintStudentNames(Section section)
        {
            Console.WriteLine("The section is "+section.SectionName+", the students are :");
            foreach (Student student in section.students)
            {
            Console.WriteLine(student.FirstName+" "+student.LastName);
            }
        }

        public static void PrintAssignmentGrades(Assignment assignment)
        {
            Console.WriteLine(assignment.AssignmentName+" of "+assignment.Section.SectionName+", the total grade is "+assignment.Total+", and the students grades are :");
            foreach (Grade grade in assignment.grades)
            {
                Console.WriteLine(grade.student.FirstName+" "+grade.student.LastName + " " + grade.studentTotal);
            }
        }


    }
}
