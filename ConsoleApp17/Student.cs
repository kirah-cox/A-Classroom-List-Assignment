using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyEnums;

namespace SnowEDU
{
    public class Student
    {
        public Names Name { get; set; }
        public Grades Grade { get; set; }

        public Student(Names name, Grades grade)
        {
            Name = name;
            Grade = grade;
        }

        public Student()
        {
            Name = RandomName();
            Grade = RandomGrade();
        }

        public Names RandomName()
        {
            Random random = new Random();
            Array enumValues = Enum.GetValues(typeof(Names));
            int randomName = random.Next(0, enumValues.Length);
            return (Names)randomName;
        }
        public Grades RandomGrade()
        {
            Random random = new Random();
            Array enumValues = Enum.GetValues(typeof(Grades));
            int randomGrade = random.Next(0, enumValues.Length);
            return (Grades)randomGrade;
        }
    }
}
