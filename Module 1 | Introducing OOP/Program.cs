using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPcs_Mod1_SelfAssessmentLab
{
    class Program
    {
        static void Main(string[] args)
        {

            // Instantiating 3 Student objects
            var Student1 = new Student();
            var Student2 = new Student();
            var Student3 = new Student();
            // Instantiating 1 Teacher object
            var Teacher1 = new Teacher();

            // Instantiating Course object with name
            var Course1 = new Course("Programming with C#");
            // Adding the 3 students to the Course object
            Course1.EnrolledStudents = Student.CountStudents();
            // Adding the 1 teacher to the Course object
            Course1.Professors = Teacher.CountTeachers();

            // Instantiating Degree object with name
            var Degree1 = new Degree("Bachelor");
            // Adding Course object to Degree object
            Degree1.DegreeCourse = Course1;

            // Instantiating an object of UProgram() Class
            var UProgram1 = new UProgram("Information Technology")
            {
                // Adding Degree object to UProgram object
                UProgramDegree = Degree1
            };


            Console.WriteLine($"The {UProgram1.Name} program is a {UProgram1.UProgramDegree.Name} degree.");
            Console.WriteLine($"Part of that degree is the {Degree1.DegreeCourse.Name} course.");
            Console.WriteLine($"Currently there are {Course1.EnrolledStudents} students enrolled in the course.");
            

           // The output of this code is
           //
           // The Information Technology program is a Bachelor degree.
           // Part of that degree is the Programming with C# course.
           // Currently there are 3 students enrolled in the course.
        }
    }
}
