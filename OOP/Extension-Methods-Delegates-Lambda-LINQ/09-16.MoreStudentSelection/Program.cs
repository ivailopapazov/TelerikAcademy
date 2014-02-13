using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreStudentSelection
{
    class Program
    {
        static void Main()
        {
            /*
             * 9.Create a class student with properties FirstName, LastName, FN, Tel, Email,
             * Marks (a List<int>), GroupNumber. Create a List<Student> with sample students.
             * Select only the students that are from group number 2. Use LINQ query.
             * Order the students by FirstName.
             */

            // Separator
            String separator = new string('-', 20);
            
            // Creating array of students field
            List<Student> students = new List<Student>
            {
                new Student("Dwayne", "Johnson", "132503", "064696011", "dwayne@abv.bg", 1, new List<int>() { 6,3 }, 1),
                new Student("Vin", "Diesel", "122606", "0873669952", "diesel@gmail.com", 2, new List<int>() { 3, 5, 3, 4 }, 2),
                new Student("Rosie", "Huntington-Whiteley", "206006", "026505543", "rose@abv.bg", 3, new List<int>() { 2, 6}, 3),
                new Student("Jason", "Statham","504503", "027304441", "jason@hotmail.com", 4, new List<int>() { 3, 5 }, 3),
                new Student("Megan", "Fox", "607506", "020256973", "m.fox@abv.bg", 1, new List<int>() { 2, 4, 2 }, 2),
                new Student("Miranda", "Kerr","025011", "0888123321", "kerr@abv.bg", 2, new List<int>() { 6, 5, 5, 4 }, 1),
                new Student("Leonardo", "DiCaprio", "054206", "064885203", "di@gmail.com", 2, new List<int>() { 6 }, 2),
                new Student("Emma", "Watson", "321012", "021234567", "emma@abv.bg", 3, new List<int>() { 6, 6, 6, 6, 6 }, 3),
                new Student("Kristen ", "Stewart", "124206", "0897030405", "stewart.kristen@abv.bg", 2, new List<int>() { 5 }, 2),
                new Student("Selena ", "Gomez", "508205", "026547891", "sgomez@gmail.com", 4, new List<int>() { 6, 5 }, 1),
                new Student("Miley", "Cyrus", "087006", "021346795", "miley@abv.bg", 2, new List<int>() { 6 }, 2),
                new Student("Taylor", "Swift", "325510", "029764315", "swift@abv.bg", 2, new List<int>() { 4, 3 }, 3),
            };

            // Select students from group 2
            IEnumerable<Student> groupTwo =
                from student in students
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;

            // Print group 2
            Console.WriteLine("9.List of students in group 2(LINQ query):");
            foreach (Student student in groupTwo)
            {
                Console.WriteLine("{0} {1} - group {2}", student.FirstName, student.LastName, student.GroupNumber);
            }
            Console.WriteLine(separator);

            /* 
             * 10.Implement the previous using the same query
             * expressed with extension methods.
             */

            // Select students from group 2 with extension methods
            IEnumerable<Student> groupTwoList = students.Where(student => student.GroupNumber == 2).OrderBy(student => student.FirstName);

            // Print group 2
            Console.WriteLine("10.List of students in group 2(Extension methods):");
            foreach (Student student in groupTwoList)
            {
                Console.WriteLine("{0} {1} - group {2}", student.FirstName, student.LastName, student.GroupNumber);
            }
            Console.WriteLine(separator);

            /*
             * 11.Extract all students that have email in abv.bg.
             * Use string methods and LINQ.
             */

            // Select students with abv email.
            IEnumerable<Student> abvCliens =
                from student in students
                where student.Email.Contains("@abv.bg")
                select student;

            // Print abv clients
            Console.WriteLine("11.Students with abv email:");
            foreach (Student student in abvCliens)
            {
                Console.WriteLine("{0} {1} - group {2}", student.FirstName, student.LastName, student.Email);
            }
            Console.WriteLine(separator);

            /*
             * 12.Extract all students with phones in Sofia.
             * Use LINQ.
             */

            // Select students with phones in sofia
            IEnumerable<Student> studentsInSofia =
                from student in students
                where student.Tel.StartsWith("02")
                select student;

            // Print result
            Console.WriteLine("12.Students with phones in sofia.");
            foreach (Student student in studentsInSofia)
            {
                Console.WriteLine("{0} {1} - group {2}", student.FirstName, student.LastName, student.Tel);
            }
            Console.WriteLine(separator);

            /*
             * 13.Select all students that have at least one mark Excellent (6)
             * into a new anonymous class that has properties – FullName and Marks. 
             * Use LINQ.
             */

            // Select students into new anonymous collection
            var exelentStudents =
                from student in students
                where student.Marks.Contains(6)
                select new
                {
                    FullName = string.Format("{0} {1}", student.FirstName, student.LastName),
                    Marks = student.Marks
                };

            // Print exelect students
            Console.WriteLine("13.Exelent students: ");
            foreach (var student in exelentStudents)
            {
                // Join mark into string
                Console.WriteLine("{0} Marks: {1}", student.FullName, string.Join(", ", student.Marks));
            }
            Console.WriteLine(separator);

            /* 
             * 14.Write down a similar program that extracts the students 
             * with exactly two marks "2". Use extension methods.
             */

            // Make selection
            var exelentStudentsList =
                students.Where(student => student.Marks.Count == 2).
                Select(student => new
                {
                    FullName = string.Format("{0} {1}", student.FirstName, student.LastName),
                    Marks = student.Marks
                });

            // Print result
            Console.WriteLine("14.Students with 2 marks:");
            foreach (var student in exelentStudentsList)
            {
                // Join mark into string
                Console.WriteLine("{0} Marks: {1}", student.FullName, string.Join(", ", student.Marks));
            }
            Console.WriteLine(separator);

            /*
             * 15.Extract all Marks of the students that enrolled in 2006. 
             * (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
             */

            // Select students enrolled in 2006
            var studentsEnrolled2006 =
                from student in students
                where student.FN.EndsWith("06")
                select new
                {
                    FullName = string.Format("{0} {1}", student.FirstName, student.LastName),
                    Marks = student.Marks
                };

            // Print result
            Console.WriteLine("15.Students enrolled 2006:");
            foreach (var student in studentsEnrolled2006)
            {
                // Join mark into string
                Console.WriteLine("{0} Marks: {1}", student.FullName, string.Join(", ", student.Marks));
            }
            Console.WriteLine(separator);

            /* 
             * 16.Create a class Group with properties GroupNumber and DepartmentName.
             * Introduce a property Group in the Student class.
             * Extract all students from "Mathematics" department.
             * Use the Join operator.
             */

            // Create groups. Note: students already belongs to a group by ID number of the group.
            Group[] groups = new Group[] 
            {
                new Group(1, "Science"),
                new Group(2, "Mathematics"),
                new Group(3, "Physics")
            };

            // Extract all students from mathematics department
            var mathGroup =
                from student in students
                join gr in groups on student.Group equals gr.GroupNumber
                where gr.DepartmentName == "Mathematics"
                select new
                {
                    FullName = string.Format("{0} {1}", student.FirstName, student.LastName),
                    Department = gr.DepartmentName
                };

            // Print students from mathematics department
            Console.WriteLine("16.Students from mathematics department.");
            foreach (var student in mathGroup)
            {
                Console.WriteLine("{0} - {1}", student.FullName, student.Department);
            }
        }
    }
}
