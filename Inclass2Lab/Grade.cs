using System;
using System.Collections.Generic;
using System.Text;

namespace Inclass2Lab
{
    public class Grade
    {
        public Student student { get; set; }
        public int studentTotal { get; set; }

        public Grade(Student student,int studentTotal)
        {
            this.student = student;
            this.studentTotal = studentTotal;
        }
    }
}
