using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectStudents
{
    class SelectStudents
    {
        static void Main(string[] args)
        {

            // Separator
            String separator = new string('-', 20);

            // Creating array of students field
            Student[] students = new Student[]
            {
                new Student("Dwayne", "Johnson", 41),
                new Student("Vin", "Diesel", 46),
                new Student("Rosie", "Huntington-Whiteley", 26),
                new Student("Jason", "Statham", 46),
                new Student("Megan", "Fox", 27),
                new Student("Miranda", "Kerr", 30),
                new Student("Leonardo", "DiCaprio", 39),
                new Student("Emma", "Watson", 23),
                new Student("Kristen ", "Stewart", 23),
                new Student("Selena ", "Gomez", 21),
                new Student("Miley", "Cyrus", 21),
                new Student("Taylor", "Swift", 24),
            };

            /* 3.Write a method that from a given array of students finds all students
             * whose first name is before its last name alphabetically. Use LINQ query operators.
             */

            // Select students
            IEnumerable<Student> selectedStudents = 
                from student in students
                where student.FirstName.CompareTo(student.LastName) > 0
                select student;

            // Print students
            Console.WriteLine("Students whose first name is before its last name alphabetically:");
            foreach (Student student in selectedStudents)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
            Console.WriteLine(separator);

            /* 4.Write a LINQ query that finds the first name and 
             * last name of all students with age between 18 and 24.
             */

            // Select students
            IEnumerable<Student> studentsBetween18and24 =
                from student in students
                where student.Age >= 18 && student.Age <= 24
                select student;

            // Print students
            Console.WriteLine("Students with age between 18 and 24");
            foreach (Student student in studentsBetween18and24)
            {
                Console.WriteLine("{0} {1} age: {2}", student.FirstName, student.LastName, student.Age);
            }
            Console.WriteLine(separator);

            /* Using the extension methods OrderBy() and ThenBy()
             * with lambda expressions sort the students by first name
             * and last name in descending order. Rewrite the same with LINQ.
             */

            // Order students with methods.
            IEnumerable<Student> orderedStudents = students.OrderByDescending(student => student.FirstName).ThenByDescending(student => student.LastName);

            // Print students
            Console.WriteLine("Print students by first name descending then by last name descending.");
            Console.WriteLine("Using ORderBy() and ThanBy():");
            foreach (Student student in orderedStudents)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
            Console.WriteLine(separator);

            // Order students with LINQ query
            IEnumerable<Student> orderedStudentsWithLINQ =
                from student in students
                orderby student.FirstName descending, student.LastName descending
                select student;

            // Print students
            Console.WriteLine("Using LINQ query:");
            foreach (Student student in orderedStudentsWithLINQ)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}
