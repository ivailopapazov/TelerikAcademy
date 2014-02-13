using System;

namespace Attributes
{
    /// <summary>
    /// Represents version of a class defined in the format major.minor
    /// </summary>
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class |
        AttributeTargets.Interface | AttributeTargets.Enum |
        AttributeTargets.Method, AllowMultiple = false)]
    public class VersionAttribute : Attribute
    {
        /// <summary>
        /// Gets the version of current data type.
        /// </summary>
        public string Version { get; private set; }
        
        /// <summary>
        /// Initializes new instance of the VersionAttribute class.
        /// </summary>
        /// <param name="version"></param>
        public VersionAttribute(string version)
        {
            this.Version = version;
        }
    }
}
