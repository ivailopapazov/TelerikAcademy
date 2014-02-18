using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanModel
{
    /// <summary>
    /// Represents a human worker.
    /// </summary>
    class Worker : Human
    {
        public int WeekSalary { get; private set; }
        public int WorkHoursPerDay { get; private set; }

        /// <summary>
        /// Initializes new instance of a worker class to a specified firstname, lastname, weeksalary and workhours.
        /// </summary>
        /// <param name="firstName">First name of a worker.</param>
        /// <param name="lastName">Last name of a worker.</param>
        /// <param name="weekSalary">Week salary of a worker.</param>
        /// <param name="workHoursPerDay">Work hours per day.</param>
        public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        /// <summary>
        /// Calculates the salary of a worker for an hour work.
        /// </summary>
        /// <returns>Salary per hour.</returns>
        public decimal MoneyPerHour()
        {
            // Using decimal cast for more precise calculation.
            return this.WeekSalary / (decimal)(this.WorkHoursPerDay * 5);
        }
    }
}
