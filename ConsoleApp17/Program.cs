using SnowEDU;
using MyEnums;

public class Program
{
    static void Main()
    {
        List<Student> studentList = new List<Student>();
        
        Teacher teacher = new Teacher("Matthew James", studentList);

        Student student1 = new Student();
        Student student2 = new Student();
        Student student3 = new Student();

        teacher.AddStudent(student1);
        teacher.AddStudent(student2);
        teacher.AddStudent(student3);

        teacher.TeacherGreeting(teacher);

        teacher.DisplayStudents(studentList);

        teacher.CalculateAverageGrade(studentList);

        
        


    }
}