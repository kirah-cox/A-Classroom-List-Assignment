using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnowEDU
{
    public class Student
    {
        public string Name { get; set; }
        public string Grade { get; set; }

        public Student(string name, string grade)
        {
            Name = name;
            Grade = grade;
        }
    }
}
