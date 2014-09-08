namespace EntityFramework.DataAccess
{
    using EntityFramework.Data;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class NorthwindDataAccess
    {
        private static NorthwindEntities northwindContext;

        public static void Initialize(NorthwindEntities context)
        {
            northwindContext = context;
        }

        public static void InsertCustomer(
            string customerID,
            string companyName,
            string contactName,
            string contactTitle,
            string address,
            string city,
            string region,
            string postalCode,
            string country,
            string phone,
            string fax)
        {
            Customer newCustomer = new Customer()
            {
                CustomerID = customerID,
                CompanyName = companyName,
                ContactName = contactName,
                ContactTitle = contactTitle,
                Address = address,
                City = city,
                Region = region,
                PostalCode = postalCode,
                Country = country,
                Phone = phone,
                Fax = fax
            };

            northwindContext.Customers.Add(newCustomer);

            northwindContext.SaveChanges();
        }

        public static void UpdateCustomer(
            string customerID,
            string companyName,
            string contactName,
            string contactTitle,
            string address,
            string city,
            string region,
            string postalCode,
            string country,
            string phone,
            string fax)
        {
            Customer customerToUpdate = GetCustomerById(customerID);

            customerToUpdate.CompanyName = companyName;
            customerToUpdate.ContactName = contactName;
            customerToUpdate.ContactTitle = contactTitle;
            customerToUpdate.Address = address;
            customerToUpdate.City = city;
            customerToUpdate.Region = region;
            customerToUpdate.PostalCode = postalCode;
            customerToUpdate.Country = country;
            customerToUpdate.Phone = phone;
            customerToUpdate.Fax = fax;

            northwindContext.SaveChanges();
        }

        public static void RemoveCustomer(string customerID)
        {
            Customer customerToDelete = GetCustomerById(customerID);
            northwindContext.Customers.Remove(customerToDelete);
            northwindContext.SaveChanges();

        }

        public static Customer GetCustomerById(string customerID)
        {
            Customer customer = northwindContext.Customers.Single(c => c.CustomerID == customerID);

            return customer;
        }
    }
}
