using System;

namespace LatihanInheritanceReal
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Adit", 19);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Thomas", 35, 190302, "Guru Matematika");
            teacher.GetNameAndAge();

            Student student = new Student("Ayana", 21, 10506, "Ayanajkt48@gmail.com");
            student.GetNameAndAge();

            Console.ReadKey();

        }
    }
}
