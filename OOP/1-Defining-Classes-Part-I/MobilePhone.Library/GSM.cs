using System;
using System.Collections.Generic;
using System.Text;

namespace MobilePhone.Library
{
    public class GSM
    {
        // Class fields
        private string model;
        private string manufacturer;
        private Battery battery;
        private Display display;
        private int? price;
        private string owner;
        private List<Call> callHistory = new List<Call>();

        // Static initializer
        /// <summary>
        /// Defines static information about IPhone4S.
        /// </summary>
        static GSM()
        {
            Battery iPhoneBattery = new Battery("Non-removable", BatteryType.LiIon);
            Display iPhoneDisplay = new Display(3, 16000000);
            IPhone4S = new GSM("4S", "Apple", iPhoneBattery, iPhoneDisplay, 1000);
        }

        /// Constructor overloads
        /// <summary>
        /// Initializes a new instance of the GSM class to a specified model and manufacturer, with a base batery and display.
        /// </summary>
        /// <param name="model">GSM model</param>
        /// <param name="manufacturer">GSM manufacturer</param>
        public GSM(string model, string manufacturer)
            : this(model, manufacturer, new Battery("Base model", BatteryType.Generic), new Display())
        {
        }

        /// <summary>
        /// Initializes a new instance of the GSM class to a specified model, a manufacturer, a battery object, a display object, a price and an owner.
        /// </summary>
        /// <param name="model">Model.</param>
        /// <param name="manufacturer">Manufacturer.</param>
        /// <param name="battery">Battery object.</param>
        /// <param name="display">Display object</param>
        /// <param name="price">Price</param>
        /// <param name="owner">Owner</param>
        public GSM(string model, string manufacturer, Battery battery, Display display, int? price = null, string owner = "Not purchased")
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Battery = battery;
            this.Display = display;
            this.Price = price;
            this.Owner = owner;
        }

        /// <summary>
        /// Gets static information about IPhone 4S;
        /// </summary>
        public static GSM IPhone4S { get; private set; }

        /// <summary>
        /// Gets or sets GSM model.
        /// </summary>
        public string Model 
        {
            get
            {
                return this.model;
            }
            set
            {
                // Validation
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("GSM model cannot be null, empty or white space.");
                }
                this.model = value;
            }
        }

        /// <summary>
        /// Gets or sets GSM manufacturer.
        /// </summary>
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                // Validation
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("GSM manufacturer cannot be null, empty or white space.");
                }
                this.manufacturer = value;
            }
        }

        /// <summary>
        /// Gets or sets GSM battery.
        /// </summary>
        public Battery Battery 
        {
            get
            {
                return this.battery;
            }
            set
            {
                // Validation
                if (value == null)
                {
                    throw new ArgumentNullException("GSM battery cannot be null.");
                }
                this.battery = value;
            }
        }

        /// <summary>
        /// Gets or sets GSM display;
        /// </summary>
        public Display Display 
        {
            get
            {
                return this.display;
            }
            set
            {
                // Validation
                if (value == null)
                {
                    throw new ArgumentNullException("GSM display cannot be null.");
                }
                this.display = value;
            }
        }

        /// <summary>
        /// Gets or sets GSM price.
        /// </summary>
        public int? Price 
        {
            get
            {
                return this.price;
            }
            set
            {
                // Validation
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("GSM price cannot be negative number.");
                }
                this.price = value;
            }
        }

        /// <summary>
        /// Gets or sets GSM owner.
        /// </summary>
        public string Owner 
        {
            get
            {
                return this.owner;
            }
            set
            {
                // Validation
                if (value.Trim() == string.Empty)
                {
                    throw new ArgumentException("GSM owner cannot be empty or white space.");
                }
                this.owner = value;
            }
        }

        /// <summary>
        /// Gets list of call history.
        /// </summary>
        public List<Call> CallHistory 
        {
            get
            {
                return this.callHistory;
            }
        }

        /// <summary>
        /// Adds new call to call history.
        /// </summary>
        /// <param name="dateTime">Datetime of the call.</param>
        /// <param name="duration">Duration of the call.</param>
        /// <param name="dialedNumber">Number of the addressee.</param>
        public void AddCall(DateTime dateTime, int duration, string dialedNumber)
        {
            // Create new call
            Call newCall = new Call(dateTime, duration, dialedNumber);

            // Adding the new call to call history list
            callHistory.Add(newCall);
        }

        /// <summary>
        /// Deletes single call from call history.
        /// </summary>
        /// <param name="callID">ID of the call.</param>
        public void DeleteCall(int callID)
        {
            // Delete call from call history
            callHistory.RemoveAt(callID);
        }

        /// <summary>
        /// Clears call history.
        /// </summary>
        public void ClearCalls()
        {
            // Clear the call history list.
            callHistory.Clear();
        }

        /// <summary>
        /// Calculates total price of the calls.
        /// </summary>
        /// <param name="pricePerMinute">Price of the calls per minute.</param>
        /// <returns></returns>
        public decimal CalculateTotalPrice(decimal pricePerMinute)
        {
            // Declaration
            decimal totalPrice = 0;
            int callsDuration = 0;

            // Calculate total call duration.
            foreach (Call call in callHistory)
            {
                callsDuration += call.Duration;
            }

            // Convert seconds to minutes
            callsDuration /= 60;
 
            // Calculate total price
            totalPrice = callsDuration * pricePerMinute;

            // Return total price
            return totalPrice;
        }

        /// <summary>
        /// Converts all GSM information into string.
        /// </summary>
        /// <returns>String representation of GSM specifications.</returns>
        public override string ToString()
        {
            // Define stringbuilder container for gsm info
            StringBuilder GSMInfo = new StringBuilder();

            // Filling container with info
            GSMInfo.AppendLine("GSM Info");
            GSMInfo.AppendLine(string.Format("Model: {0}", Model));
            GSMInfo.AppendLine(string.Format("Manufacturer: {0}", Manufacturer));
            GSMInfo.AppendLine(string.Format("Owner: {0}", Owner));
            GSMInfo.AppendLine(string.Format("Price: {0:C}", Price));
            GSMInfo.AppendLine("Battery Info");
            GSMInfo.AppendLine(string.Format("Model: {0}", Battery.Model));
            GSMInfo.AppendLine(string.Format("Battery: {0}", Battery.BatteryType));
            GSMInfo.AppendLine(string.Format("Idle: {0} hours", Battery.HoursIdle));
            GSMInfo.AppendLine(string.Format("Talk: {0} hours", Battery.HoursTalk));
            GSMInfo.AppendLine("Display Info");
            GSMInfo.AppendLine(string.Format("Size: {0}", Display.Size));
            GSMInfo.AppendLine(string.Format("Colors: {0}", Display.Colors));

            // Return
            return GSMInfo.ToString();
        }
    }
}
