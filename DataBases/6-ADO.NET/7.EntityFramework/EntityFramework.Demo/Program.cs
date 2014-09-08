using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework.DataAccess;
using EntityFramework.Data;

namespace EntityFramework.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1: context created
            using (NorthwindEntities dbContext = new NorthwindEntities())
            {
                NorthwindDataAccess.Initialize(dbContext);

                // Task 2
                InsertCustomer();
                //UpdateCustomer();
                //RemoveCustomer();

                // Task 3
            }
        }

        static void InsertCustomer()
        {
            NorthwindDataAccess.InsertCustomer(
                "TELRK",
                "Telerik Corp.",
                "Svetozar Georgiev",
                "Mr.",
                "33 Alexander Malinov Blvd.",
                "Sofia",
                "Sofia",
                "1729",
                "Bulgaria",
                "+359 2 809 98 62",
                "+359 2 809 98 62");
        }

        private static void UpdateCustomer()
        {
            NorthwindDataAccess.UpdateCustomer(
                "TELRK",
                "Telerik Corp.",
                "Vassil Terziev",
                "Mr.",
                "33 Alexander Malinov Blvd.",
                "Sofia",
                "Sofia",
                "1729",
                "Bulgaria",
                "+359 2 809 98 62",
                "+359 2 809 98 62");
        }

        private static void RemoveCustomer()
        {
            NorthwindDataAccess.RemoveCustomer("TELRK");
        }
    }
}
