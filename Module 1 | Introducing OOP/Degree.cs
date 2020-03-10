using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPcs_Mod1_SelfAssessmentLab
{
    class Degree
    {
        // Defining properties
        public Course DegreeCourse { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }

        // Adding constructor to instantiate with only a name
        public Degree(string name)
        {
            this.Name = name;
        }
    }
}
