namespace ToysStore.RandomDataGenerator.DataGenerators
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ToysStore.Data;
    using ToysStore.RandomDataGenerator.Contracts;

    internal class ManufacturerDataGenerator : DataGenerator, IDataGenerator
    {
        public ManufacturerDataGenerator(IRandomDataGenerator randomDataGenerator, ToysStoreEntities toysStoreEntities, int generationsCount, ILogger logger)
            : base(randomDataGenerator, toysStoreEntities, generationsCount, logger)
        {
        }

        public override void Generate()
        {
            HashSet<string> manufacturerNames = new HashSet<string>();

            while (manufacturerNames.Count <= this.GenerationsCount)
            {
                string manufacturerName = this.RandomDataGenerator.GetRandomStringWithRandomLength(5, 20);
                manufacturerNames.Add(manufacturerName);
            }

            this.Logger.StartOfNotification("Generating Manufacturers");
            int index = 0;
            foreach (var manufacturerName in manufacturerNames)
            {
                Manufacturer manufacturer = new Manufacturer
                {
                    Name = manufacturerName,
                    Country = this.RandomDataGenerator.GetRandomStringWithRandomLength(2, 30)
                };

                if (index % 100 == 0)
                {
                    this.Logger.NotifyProgress();
                    this.Database.SaveChanges();
                }

                this.Database.Manufacturers.Add(manufacturer);
                index++;
            }

            this.Logger.EndOfNotification();
        }
    }
}
