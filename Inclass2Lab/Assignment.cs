using System;
using System.Collections.Generic;
using System.Text;

namespace Inclass2Lab
{
    public class Assignment
    {
        public string AssignmentName { get; set; }
        public Section Section;
        public int Total { get; set; }
        public List<Grade> grades;
        
    public Assignment(string AssignmentName, Section Section, int Total, List<Grade> grades)
        {
            this.AssignmentName = AssignmentName;
            this.Section = Section;
            this.Total = Total;
            this.grades = grades;
        }
    
    }
}

