﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPcs_Mod1_SelfAssessmentLab
{
    // Declaring the Student() class
    public class Student
    {
        // Creates integer variable called  "instances" and assigns value to 0
        private static int instances = 0;

        public Student()
        {
            // Every time the constructor runs, increment "instances"
            instances++;
        }

        //
        public static int CountStudents()
        {
            return instances++;
        }
    }
}
