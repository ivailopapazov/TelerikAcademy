using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanModel
{
    /// <summary>
    /// Represents human object with basic characteristics.
    /// </summary>
    abstract class Human
    {
        public string FristName { get; set; }
        public string LastName { get; set; }

        /// <summary>
        /// Constructor for basic characteristics initialization. Used only from derived classes.
        /// </summary>
        /// <param name="firstName">First name of a human.</param>
        /// <param name="lastName">Last name of a human.</param>
        protected Human(string firstName, string lastName)
        {
            this.FristName = firstName;
            this.LastName = lastName;
        }
    }
}
