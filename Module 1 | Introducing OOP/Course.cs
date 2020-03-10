using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPcs_Mod1_SelfAssessmentLab
{
    public class Course
    {
        public string Name { get; set; }
        public int EnrolledStudents { get; set; }
        public int Professors { get; set; }

        // Adding constructor to instantiate with only a name
        public Course(string name)
        {
            this.Name = name;
        }
    }
}
