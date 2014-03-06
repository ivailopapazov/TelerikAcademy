using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    public class ConvertibleChair : Chair, IFurniture, IChair, IConvertibleChair
    {
        private const decimal ConvertedStateHeight = 0.10M;
        private readonly decimal NormalStateHeight;

        public ConvertibleChair(string model, string material, decimal price, decimal height, int numberOfLegs)
            : base(model, material, price, height, numberOfLegs)
        {
            this.NormalStateHeight = height;
        }

        public bool IsConverted { get; private set; }

        public void Convert()
        {
            if (IsConverted)
            {
                // Set normal state
                this.Height = this.NormalStateHeight;
            }
            else
            {
                // Set converted state
                this.Height = ConvertibleChair.ConvertedStateHeight;
            }

            this.IsConverted = !this.IsConverted;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(base.ToString());
            result.AppendFormat(", State: {0}", this.IsConverted ? "Converted" : "Normal");

            return result.ToString();
        }
    }
}
