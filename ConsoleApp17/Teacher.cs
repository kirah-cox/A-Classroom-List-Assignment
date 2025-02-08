using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyEnums;

namespace SnowEDU
{
    public class Teacher
    {
        public string Name { get; set; }
        public List<Student> StudentList { get; set; }

        public Teacher(string name, List<Student> studentList)
        {
            Name = name;
            StudentList = studentList;
        }

        public void TeacherGreeting(Teacher teacher)
        {
            Console.WriteLine($"This is the classroom of Professor {teacher.Name}. The grading standards are as follows:");
            Console.WriteLine("A = 95% - 100%");
            Console.WriteLine("B = 85% - 94%");
            Console.WriteLine("C = 75% - 84%");
            Console.WriteLine("D = 65% - 74%");
            Console.WriteLine("F = 0% - 64%");
            Console.WriteLine("-------------");
        }

        public void AddStudent(Student student)
        {
            StudentList.Add(student);
        }

        public void DisplayStudents(List<Student> studentList)
        {
            Console.WriteLine("Here is a list of students in this class:");
            foreach (Student student in StudentList)
            {
                Console.WriteLine($"{student.Name}, {student.Grade}");
            }
            Console.WriteLine("-------------");
        }

        public void CalculateAverageGrade(List<Student> studentList)
        {
            List<double> gradePercent = new List<double>();
            foreach (Student student in StudentList)
            {
                switch (student.Grade)
                {
                    case Grades.A:
                        gradePercent.Add(1);
                        break;
                    case Grades.B:
                        gradePercent.Add(.9);
                        break;
                    case Grades.C:
                        gradePercent.Add(.8);
                        break;
                    case Grades.D:
                        gradePercent.Add(.7);
                        break;
                    case Grades.F:
                        gradePercent.Add(.6);
                        break;
                }
                
            }

            double result = gradePercent.Average();

            if(result >= .95)
            {
                Console.WriteLine($"The average grade is an A with the average percentage being {result:P}.");
            }
            else if(result >= .85)
            {
                Console.WriteLine($"The average grade is a B with the average percentage being {result:P}.");
            }
            else if (result >= .75)
            {
                Console.WriteLine($"The average grade is a C with the average percentage being {result:P}.");
            }
            else if (result >= .65)
            {
                Console.WriteLine($"The average grade is a D with the average percentage being {result:P}.");
            }
            else
            {
                Console.WriteLine($"The average grade is an F with the average percentage being {result:P}.");
            }
        }
    }
}
