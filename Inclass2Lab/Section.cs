using System;
using System.Collections.Generic;
using System.Text;

namespace Inclass2Lab
{
   public class Section
    {
        public string SectionNumber { get; set; }
        public string SectionName { get; set; }
        public List<Student> students;

        public Section(string SectionNumber, string SectionName, List<Student> students)
        {
            this.SectionNumber = SectionNumber;
            this.SectionName = SectionName;
            this.students = students;
        }
    }

}
