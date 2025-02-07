using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
