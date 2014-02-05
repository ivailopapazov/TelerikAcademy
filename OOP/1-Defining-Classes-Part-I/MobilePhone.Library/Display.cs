using System;

namespace MobilePhone.Library
{
    public class Display
    {
        // Class fields
        private double? size;
        private int? colors;

        // Class properties
        public double? Size
        {
            get
            {
                return size;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Display size cannot be less than or equal to zero.");
                }
                this.size = value;
            }
        }
        public int? Colors
        {
            get
            {
                return colors;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Display colors cannot be less than or equal to zero.");
                }
                this.colors = value;
            }
        }

        // Class constructors
        public Display() : this(null)
        {

        }
        public Display(double? size) : this(size, null)
        {
        }
        public Display(double? size, int? colors)
        {
            this.Size = size;
            this.Colors = colors;
        }
    }
}
