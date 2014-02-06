using System;

namespace MobilePhone.Library
{
    /// <summary>
    /// Represents GSM display and it's characteristics.
    /// </summary>
    public class Display
    {
        // Class fields
        private double? size;
        private int? colors;

        /// <summary>
        /// Initializes new instance of the display class.
        /// </summary>
        public Display()
            : this(null)
        {

        }
        /// <summary>
        /// Initializes new instance of the display class.
        /// </summary>
        /// <param name="size">Size of the display.</param>
        public Display(double? size)
            : this(size, null)
        {
        }

        /// <summary>
        /// Initializes new instance of the display class.
        /// </summary>
        /// <param name="size">Size of the display.</param>
        /// <param name="colors">Number of colors the display supports.</param>
        public Display(double? size, int? colors)
        {
            this.Size = size;
            this.Colors = colors;
        }

        /// <summary>
        /// Gets or sets size of the display.
        /// </summary>
        public double? Size
        {
            get
            {
                return size;
            }
            set
            {
                // Validation
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Display size cannot be less than or equal to zero.");
                }
                this.size = value;
            }
        }

        /// <summary>
        /// Gets or sets numbers of colors the display supports.
        /// </summary>
        public int? Colors
        {
            get
            {
                return colors;
            }
            set
            {
                // Validation
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Display colors cannot be less than or equal to zero.");
                }
                this.colors = value;
            }
        }
    }
}
