using System;
using System.Linq;

namespace SchoolModel
{
    /// <summary>
    /// Represents an abstract class for every school object.
    /// </summary>
    public abstract class SchoolObject
    {
        /// <summary>
        /// Gets or sets a comment for every school object.
        /// </summary>
        public string Comments { get; set; }
    }
}
