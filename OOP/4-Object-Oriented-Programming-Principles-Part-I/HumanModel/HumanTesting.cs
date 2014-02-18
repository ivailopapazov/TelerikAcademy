using System;
using System.Collections.Generic;
using System.Linq;

namespace HumanModel
{
    class HumanTesting
    {
        static void Main()
        {
            // Initialize list of students
            List<Student> students = new List<Student>()
            {
                new Student("Ivan", "Ivanov", 5),
                new Student("Georgi", "Georgiev", 2),
                new Student("Petur", "Petrov", 4),
                new Student("Naiden", "Naidenov", 3),
                new Student("Orling", "Goranov", 2),
                new Student("Rosen", "Petrov", 1),
                new Student("Harry", "Potter", 1),
                new Student("Isac", "Asimov", 10),
                new Student("50", "Cent", 2),
                new Student("Robert", "DeNiro", 12),
            };

            // Initialize list of workers
            List<Worker> workers = new List<Worker>()
            {
                new Worker("Boiko", "Borisov", 650, 30),
                new Worker("Sergei", "Stanishev", 1000, 40),
                new Worker("Liutvi", "Mestan", 800, 25),
                new Worker("Volen", "Siderov", 300, 12),
                new Worker("Cvetan", "Cvetanov", 600, 45),
                new Worker("Maya", "Manolova", 700, 28),
                new Worker("Ahmed", "Dogan", 1500, 5),
                new Worker("Plamen", "Oresharski", 50, 48),
                new Worker("Mihail", "Mikov", 570, 35),
                new Worker("Yane", "Yanev", 1000, 15),
            };

            // Order students by grade
            IEnumerable<Student> orderedStudents =
                from student in students
                orderby student.Grade ascending
                select student;
            
            // Print ordered students
            foreach (var student in orderedStudents)
            {
                Console.WriteLine("{0} {1} - {2} grade.", student.FristName, student.LastName, student.Grade);
            }

            // Order workers by money per hour salary
            IEnumerable<Worker> orderedWorkers =
                from worker in workers
                orderby worker.MoneyPerHour() descending
                select worker;

            // Print ordered workers
            Console.WriteLine(new string('-', 25));
            foreach (var worker in orderedWorkers)
            {
                Console.WriteLine("{0} {1} - {2:C} per hour", worker.FristName, worker.LastName, worker.MoneyPerHour());
            }

            // Merge lists into human list and order by first name then by last name.
            IEnumerable<Human> humans = new List<Human>()
                .Concat(students)
                .Concat(workers)
                .OrderBy(human => human.FristName)
                .ThenBy(human => human.LastName);

            // Print merged list
            Console.WriteLine(new string('-', 25));
            foreach (var human in humans)
            {
                Console.WriteLine("{0} {1}", human.FristName, human.LastName);
            }
        }
    }
}
