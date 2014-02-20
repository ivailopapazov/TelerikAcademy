using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 18.Write a program to return the string with maximum length
             * from an array of strings. Use LINQ.
             */

            // Create list of students.
            List<Student> students = new List<Student>() 
            {
                new Student("Pesho", "Math"),
                new Student("Gosho", "Science"),
                new Student("Tosho", "Math"),
                new Student("Niki", "Physics"),
                new Student("Vladi", "Physics"),
                new Student("Venci", "Math"),
                new Student("Ivo", "Science"),
                new Student("Svetlio", "Math"),
            };

            // Separate students into groups
            IEnumerable<IEnumerable<Student>> groups =
                from student in students
                group student by student.Group into sGroup
                select sGroup;

            // Foreach group
            foreach (IEnumerable<Student> group in groups)
            {
                // Foreach student in group
                foreach (Student student in group)
                {
                    // Print student and gorup
                    Console.WriteLine("{0} {1}", student.Name, student.Group);
                }
            }
            Console.WriteLine(new string('-', 20));
            
            /* 
             * 19.Rewrite the previous using extension methods.
             */

            // Separate students into gropus
            var studentGroups = students.GroupBy(student => student.Group);

            // Foreach group
            foreach (IEnumerable<Student> group in studentGroups)
            {
                // Foreach student
                foreach (Student student in group)
                {
                    // Print students
                    Console.WriteLine("{0} {1}", student.Name, student.Group);
                }
            }
        }
    }
}
