using System;

namespace MobilePhone.Library
{
    /// <summary>
    /// Represents a call performed through a GSM.
    /// </summary>
    public class Call
    {
        // Class fields
        private DateTime dateTime;
        private int duration;
        private string dialedNumber;

        /// <summary>
        /// Initializes a new instance of class Call.
        /// </summary>
        /// <param name="dateTime">Date and time of the call.</param>
        /// <param name="duration">Duration of the call in seconds.</param>
        /// <param name="dialedNumber">The number of the addressee.</param>
        public Call(DateTime dateTime, int duration, string dialedNumber)
        {
            this.DateTime = dateTime;
            this.Duration = duration;
            this.DialedNumber = dialedNumber;
        }

        /// <summary>
        /// Gets the DateTime of the call.
        /// </summary>
        public DateTime DateTime 
        {
            get
            {
                return this.dateTime;
            }
            private set
            {
                // Validation
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("Datetime of the call cannot be in the future.");
                }
                this.dateTime = value;
            }
        }

        /// <summary>
        /// Gets the duration of the call.
        /// </summary>
        public int Duration
        {
            get
            {
                return this.duration;
            }
            private set
            {
                // Validation
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Duration of the call cannot be negative number.");
                }
                this.duration = value;
            }
        }

        /// <summary>
        /// Gets the number of the addressee.
        /// </summary>
        public string DialedNumber
        {
            get
            {
                return this.dialedNumber;
            }
            private set
            {
                // Validation
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Dialed number cannot be null, empty or white space.");
                }
                this.dialedNumber = value;
            }
        }
    }
}
