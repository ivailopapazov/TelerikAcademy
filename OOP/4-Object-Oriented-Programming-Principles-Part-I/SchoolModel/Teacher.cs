using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolModel
{
    /// <summary>
    /// Represents teacher.
    /// </summary>
    public class Teacher : Person
    {
        /// <summary>
        /// Initializes new instance of teacher class to the specified name.
        /// </summary>
        /// <param name="name">Teacher's name</param>
        public Teacher(string name)
            : this(name, null)
        {
        }

        /// <summary>
        /// Initializes new instance of teacher class to the specified name and set of diciplines.
        /// </summary>
        /// <param name="name">Teacher's name</param>
        /// <param name="disciplines">Set of disciplines.</param>
        public Teacher(string name, IEnumerable<Discipline> disciplines)
            : base(name)
        {
            this.Disciplines = disciplines.ToList();
        }

        /// <summary>
        /// Gets the list of disciplines.
        /// </summary>
        public List<Discipline> Disciplines { get; private set; }

        /// <summary>
        /// Adds discipline to the set of disciplines.
        /// </summary>
        /// <param name="discipline"></param>
        public void AddDiscipline(Discipline discipline)
        {
            this.Disciplines.Add(discipline);
        }
    }
}
