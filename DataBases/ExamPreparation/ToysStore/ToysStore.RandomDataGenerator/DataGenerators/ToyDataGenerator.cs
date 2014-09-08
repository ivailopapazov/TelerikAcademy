namespace ToysStore.RandomDataGenerator.DataGenerators
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ToysStore.Data;
    using ToysStore.RandomDataGenerator.Contracts;

    internal class ToyDataGenerator : DataGenerator, IDataGenerator
    {
        public ToyDataGenerator(IRandomDataGenerator randomDataGenerator, ToysStoreEntities toysStoreEntities, int generationsCount, ILogger logger)
            : base(randomDataGenerator, toysStoreEntities, generationsCount, logger)
        {
        }

        public override void Generate()
        {
            var manufacturerIds = this.Database.Manufacturers.Select(manufacturer => manufacturer.Id).ToList();
            var rangesIds = this.Database.AgeRanges.Select(ageRanges => ageRanges.Id).ToList();
            var categoryIds = this.Database.Categories.Select(category => category.Id).ToList();

            this.Logger.StartOfNotification("Generating Toys!");

            for (int i = 0; i < this.GenerationsCount; i++)
            {
                string color;
                if (this.RandomDataGenerator.GetRandomNumber(1, 6) == 5)
                {
                    color = null;
                }
                else
                {
                    color = this.RandomDataGenerator.GetRandomStringWithRandomLength(5, 20);
                }

                Toy toy = new Toy 
                {
                    Name = this.RandomDataGenerator.GetRandomStringWithRandomLength(5, 20),
                    Type = this.RandomDataGenerator.GetRandomStringWithRandomLength(5, 20),
                    Price = this.RandomDataGenerator.GetRandomNumber(10, 500),
                    Color = color,
                    ManufacturerId = manufacturerIds[this.RandomDataGenerator.GetRandomNumber(0, manufacturerIds.Count)],
                    AgeRangeId = rangesIds[this.RandomDataGenerator.GetRandomNumber(0, rangesIds.Count)],
                };

                if (categoryIds.Count > 0)
                {
                    HashSet<int> uniqueCategoryIds = new HashSet<int>();
                    int uniqueCategoriesCount = this.RandomDataGenerator.GetRandomNumber(1, Math.Min(10, categoryIds.Count));

                    while (uniqueCategoryIds.Count < uniqueCategoriesCount)
                    {
                        uniqueCategoryIds.Add(categoryIds[this.RandomDataGenerator.GetRandomNumber(0, categoryIds.Count)]);
                    }

                    foreach (var uniqueCategoryId in uniqueCategoryIds)
                    {
                        toy.Categories.Add(this.Database.Categories.Find(uniqueCategoryId));
                    }
                }

                this.Database.Toys.Add(toy);

                if (i % 100 == 0)
                {
                    this.Logger.NotifyProgress();
                    this.Database.SaveChanges();
                }
            }

            this.Logger.EndOfNotification();
        }
    }
}
