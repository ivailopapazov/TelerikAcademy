using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    public abstract class Furniture : IFurniture
    {
        private string model;
        private decimal price;
        private decimal height;
        private string material;

        protected Furniture(string model, string material, decimal price, decimal height)
        {
            this.Model = model;
            this.Material = material;
            this.Price = price;
            this.Height = height;
        }

        public string Model
        {
            get 
            {
                return this.model;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Model cannot be null or empty!");
                }

                if (value.Length < 3)
                {
                    throw new ArgumentOutOfRangeException("Model cannot be less than 3 symbols!");
                }

                this.model = value;
            }
        }

        public string Material
        {
            get 
            {
                return this.material;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Material cannot be null or empty!");
                }

                this.material = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value <= 0M)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be less than or equal to $0.00");
                }

                this.price = value;
            }
        }

        public decimal Height
        {
            get 
            {
                return this.height;
            }
            protected set
            {
                if (value <= 0M)
                {
                    throw new ArgumentOutOfRangeException("Height cannot be less than or equal to 0.00m");
                }

                this.height = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            string materialWithUpperLeather = Char.ToUpper(this.Material[0]) + this.Material.Substring(1);
            //string materialWithUpperLeather = Enum.Parse(typeof(MaterialType), this.Material);

            result.AppendFormat("Type: {0}, Model: {1}, ", this.GetType().Name, this.Model);
            result.AppendFormat("Material: {0},sPrice: {1}, ", materialWithUpperLeather, this.Price);
            result.AppendFormat("Height: {0}", this.Height);

            return result.ToString();
        }
    }
}
