namespace ToysStore.RandomDataGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ToysStore.Data;
    using ToysStore.RandomDataGenerator.Contracts;
    using ToysStore.RandomDataGenerator.DataGenerators;
    using ToysStore.RandomDataGenerator.Tools;

    internal class Program
    {
        private const int NumberOfCategories = 100;
        private const int NumberOfManufacturers = 50;
        private const int NumberOfAgeRanges = 100;
        private const int NumebrOfToys = 20000;

        internal static void Main()
        {
            var random = RandomDataGenerator.Instance;
            var db = new ToysStoreEntities();
            var logger = new ConsoleLogger();
            db.Configuration.AutoDetectChangesEnabled = false;

            List<IDataGenerator> generators = new List<IDataGenerator>
            {
                new CategoryDataGenerator(random, db, NumberOfCategories, logger),
                new ManufacturerDataGenerator(random, db, NumberOfManufacturers, logger),
                new AgeRangeDataGenerator(random, db, NumberOfAgeRanges, logger),
                new ToyDataGenerator(random, db, NumebrOfToys, logger)
            };

            foreach (var generator in generators)
            {
                generator.Generate();
                db.SaveChanges();
            }
        }
    }
}
