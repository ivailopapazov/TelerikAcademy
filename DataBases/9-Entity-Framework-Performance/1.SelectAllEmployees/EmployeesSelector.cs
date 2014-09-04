using _00.DatabaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace _1.SelectAllEmployees
{
    class EmployeesSelector
    {
        static void Main()
        {
            using (TelerikAcademyDb db = new TelerikAcademyDb())
            {
                //SelectEmployeesWithInclude(db);
                //SelectEmployeesWithoutInclude(db);
                //SelectEmployeesUsingToList(db);
                SelectEmployeesLikeABoss(db);
            }
        }

        private static void SelectEmployeesWithInclude(TelerikAcademyDb db)
        {
            var employees = db.Employees
                .Include(employee => employee.Department)
                .Include(employee => employee.Address.Town);

            foreach (var employee in employees)
            {
                Console.WriteLine("{0} {1} - {2} -{3}", employee.FirstName, employee.LastName, employee.Department.Name, employee.Address.Town.Name);
            }
        }

        private static void SelectEmployeesWithoutInclude(TelerikAcademyDb db)
        {
            var employees = db.Employees.Select(employee =>
                new
                {
                    name = employee.FirstName + " " + employee.LastName,
                    department = employee.Department.Name,
                    town = employee.Address.Town.Name
                });

            foreach (var employee in employees)
            {
                Console.WriteLine("{0} - {1} -{2}", employee.name, employee.department, employee.town);
            }
        }

        private static void SelectEmployeesUsingToList(TelerikAcademyDb db)
        {
            var employees = db.Employees.ToList()
                .Select(employee => employee.Address).ToList()
                .Select(address => address.Town).ToList()
                .Where(town => town.Name == "Sofia");

            Console.WriteLine();
        }

        private static void SelectEmployeesLikeABoss(TelerikAcademyDb db)
        {
            var employees = db.Employees
                .Select(employee =>
                new
                {
                    Name = employee.FirstName + " " + employee.LastName,
                    Address = employee.Address.AddressText,
                    Town = employee.Address.Town.Name
                })
                .Where(employee => employee.Town == "Sofia");

            foreach (var employee in employees)
            {
                Console.WriteLine("{0} - {1} - {2}", employee.Name, employee.Address, employee.Town);
            }
        }
    }
}
