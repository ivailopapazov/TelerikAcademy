using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    public class Company : ICompany
    {
        private string name;
        private string registrationNumber;
        private ICollection<IFurniture> furnitures;

        public Company(string name, string registrationNumber)
        {
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
            furnitures = new List<IFurniture>();
        }

        public string Name
        {
            get 
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Company name cannot be null or empty!");
                }

                if (value.Length < 5)
                {
                    throw new ArgumentOutOfRangeException("Company name cannot be less than 5 symbols!");
                }

                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get 
            {
                return this.registrationNumber;
            }
            private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Company name cannot be null or empty!");
                }

                if (value.Length != 10)
                {
                    throw new ArgumentOutOfRangeException("Company registration number must be exactly 10 symbols!");
                }

                bool hasCharacters = value
                    .Any((character) => Char.IsDigit(character) == false);

                if (hasCharacters)
                {
                    throw new ArgumentException("Company registration number must contain only digits!");
                }

                this.registrationNumber = value;

            }
        }

        public ICollection<IFurniture> Furnitures
        {
            get 
            {
                return new List<IFurniture>(this.furnitures);
            }
        }

        public void Add(IFurniture furniture)
        {
            if (furniture == null)
            {
                throw new ArgumentNullException("Furniture cannot be null!");
            }

            this.furnitures.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            if (furniture == null)
            {
                throw new ArgumentNullException("Furniture cannot be null!");
            }

            this.furnitures.Remove(furniture);
        }

        public IFurniture Find(string model)
        {
            if (string.IsNullOrEmpty(model))
            {
                throw new ArgumentNullException("Model cannot be null or empty!");
            }

            var furnitureByModel = this.furnitures
                .Where((furniture) => furniture.Model.Equals(model, StringComparison.OrdinalIgnoreCase))
                .FirstOrDefault();

            return furnitureByModel;
        }

        public string Catalog()
        {
            StringBuilder result = new StringBuilder();
            string name = this.Name;
            string regNumber = this.RegistrationNumber;
            string furnitureCount = this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no";
            string furnitureWord = this.Furnitures.Count != 1 ? "furnitures" : "furniture";
            var catalog = this.furnitures
                .OrderBy((furniture) => furniture.Price)
                .ThenBy((furniture) => furniture.Model);

            result.AppendFormat("{0} - {1} - {2} {3}", name, regNumber, furnitureCount, furnitureWord);

            foreach (var item in catalog)
            {
                result.AppendLine();
                result.Append(item.ToString());
            }

            return result.ToString();
        }
    }
}
