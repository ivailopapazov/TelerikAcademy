using System;
using System.Linq;

namespace SchoolModel
{
    /// <summary>
    /// Represents a person in school.
    /// </summary>
    public abstract class Person : SchoolObject
    {
        /// <summary>
        /// Initializes name for every person object. Can be used only by derived classes.
        /// </summary>
        /// <param name="name">Name for any person object in school.</param>
        protected Person(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Gets the name of a person.
        /// </summary>
        public string Name { get; private set; }
    }
}
