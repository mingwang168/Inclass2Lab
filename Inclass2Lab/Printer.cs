using System;
using System.Collections.Generic;
using System.Text;

namespace Inclass2Lab
{
    public class Printer
    {
        public static void PrintStudentNames(Section section)
        {
            foreach (Student student in section.students)
            {
            Console.WriteLine(student.FirstName+" "+student.LastName);
            }

        }
    }
}
