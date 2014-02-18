using System;
using System.Linq;

namespace AnimalModel
{
    /// <summary>
    /// Represents a kitten.
    /// </summary>
    class Kitten : Cat
    {
        /// <summary>
        /// Initializes new instance of the class kitten to the specified age and name of the kitten.
        /// </summary>
        /// <param name="age">Kitten's age.</param>
        /// <param name="name">Kitten's name.</param>
        public Kitten(int age, string name)
            : base(age, "female", name)
        {
        }
    }
}
