using System;

namespace Exercise4
{
    class StudentAndTeacherTest
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.SayHello();

            Student student = new Student();
            student.SetAge(21);
            student.SayHello();
            student.ShowAge();

            Teacher teacher = new Teacher();
            teacher.SetAge(30);
            teacher.SayHello();
            teacher.Explain();


        }
    }
}
