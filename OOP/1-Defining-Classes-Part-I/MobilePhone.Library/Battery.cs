using System;

namespace MobilePhone.Library
{
    /// <summary>
    /// Represents GSM battery and it's characteristics.
    /// </summary>
    public class Battery
    {
        // Class fields
        private string model;
        private int? hoursIdle;
        private int? hoursTalk;

        /// <summary>
        /// Initializes a new instance of the Battery class.
        /// </summary>
        /// <param name="model">Battery model.</param>
        /// <param name="batteryType">Type of the battery.</param>
        public Battery(string model, BatteryType batteryType)
            : this(model, batteryType, null, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Battery class.
        /// </summary>
        /// <param name="model">Battery model.</param>
        /// <param name="batteryType">Type of the battery.</param>
        /// <param name="hoursIdle">Idle hours of the battery.</param>
        /// <param name="hoursTalk">Talk hours of the battery.</param>
        public Battery(string model, BatteryType batteryType, int? hoursIdle, int? hoursTalk)
        {
            this.Model = model;
            this.BatteryType = batteryType;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        /// <summary>
        /// Gets or sets model of the battery.
        /// </summary>
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                // Validation of the input value
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Battery model cannot be null, empty or white space.");
                }
                this.model = value;
            }
        }

        /// <summary>
        /// Gets or sets idle time of the battery.
        /// </summary>
        public int? HoursIdle 
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                // Validation of the input value
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("HoursIdle peroperty cannot be less than zero.");
                }
                this.hoursIdle = value;
            }
        }

        /// <summary>
        /// Gets or sets talk hours of the battery.
        /// </summary>
        public int? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                // Validation of the input value
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("HoursTalk peroperty cannot be less than zero.");
                }
                this.hoursTalk = value;
            }
        }

        /// <summary>
        /// Gets or sets battery type.
        /// </summary>
        public BatteryType BatteryType { get; set; }
    }
}
