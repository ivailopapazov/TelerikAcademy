using System;
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
        private string price;
        private string owner;
        private const string NotAvailable = "N/A";


        // Class properties


        // Class constructors
        public GSM(string model, string manufacturer) : this(model, manufacturer, null, null)
        {

        }
        public GSM(string model, string manufacturer, Battery battery, Display display, string price = null, string owner = null)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.battery = battery;
            this.display = display;
            this.price = price;
            this.owner = owner;
        }

        // Methods
        public override string ToString()
        {
            StringBuilder GSMInfo = new StringBuilder();
            //GSMInfo.AppendLine("GSM Info:");
            //GSMInfo.AppendLine(string.Format("Model: {0}", model));
            //GSMInfo.AppendLine(string.Format("Manufacturer: {0}", manufacturer));
            //GSMInfo.AppendLine(string.Format("Owner: {0}", owner));
            //GSMInfo.AppendLine(string.Format("Price: {0}", price));
            GSMInfo.AppendLine("Battery Info:");
            GSMInfo.AppendLine(string.Format("Model: {0}", battery.Model));
            GSMInfo.AppendLine(string.Format("Hours Idle: {0}", battery.HoursIdle.ToString() ?? NotAvailable));
            GSMInfo.AppendLine(string.Format("Hours Talk: {0}", battery.HoursTalk.ToString() ?? NotAvailable));
            GSMInfo.AppendLine("Display Info");
            GSMInfo.AppendLine(string.Format("Size: {0}", display.Size.ToString() ?? NotAvailable));
            GSMInfo.AppendLine(string.Format("Colors: {0}", display.Colors.ToString() ?? NotAvailable));
            return GSMInfo.ToString();
        }
    }
}
