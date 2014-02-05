using System;

namespace MobilePhone.Library
{
    public class Battery
    {
        // Class fields
        private string model;
        private int? hoursIdle;
        private int? hoursTalk;
        private BatteryType batteryType;

        // Class properties
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Model cannot be null, empty or white space.");
                }
                this.model = value;
            }
        }

        public int? HoursIdle 
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("HoursIdle peroperty cannot be less than zero.");
                }
                this.hoursIdle = value;
            }
        }

        public int? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("HoursTalk peroperty cannot be less than zero.");
                }
                this.hoursTalk = value;
            }
        }

        public BatteryType BatteryType { get; set; }

        // Class constructors
        public Battery(string model) : this(model, null, null)
        {
        }
        public Battery(string model, int? hoursIdle, int? hoursTalk)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }
    }
}
