namespace ToysStore.RandomDataGenerator.DataGenerators
{
    using System;
    using ToysStore.Data;
    using ToysStore.RandomDataGenerator.Contracts;

    internal class CategoryDataGenerator : DataGenerator, IDataGenerator
    {
        public CategoryDataGenerator(IRandomDataGenerator randomDataGenerator, ToysStoreEntities toysStoreEntities, int generationsCount, ILogger logger)
            : base(randomDataGenerator, toysStoreEntities, generationsCount, logger)
        {
        }

        public override void Generate()
        {
            this.Logger.StartOfNotification("Generating Categories!");

            for (int i = 0; i < this.GenerationsCount; i++)
            {
                Category category = new Category()
                {
                    Name = this.RandomDataGenerator.GetRandomStringWithRandomLength(5, 30)
                };

                this.Database.Categories.Add(category);

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
