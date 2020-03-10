using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPcs_Mod1_SelfAssessmentLab
{
    public class UProgram
    {
        // Defining properties
        public string Name { get; set; }
        public string Degree { get; set; }

        // Adding constructors to instantiate with only a name
        public UProgram(string name)
        {
            this.Name = name;
        }
    }
}
