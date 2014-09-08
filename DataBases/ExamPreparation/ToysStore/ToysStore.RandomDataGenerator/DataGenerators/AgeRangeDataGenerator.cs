namespace ToysStore.RandomDataGenerator.DataGenerators
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using ToysStore.Data;
    using ToysStore.RandomDataGenerator.Contracts;

    internal class AgeRangeDataGenerator : DataGenerator, IDataGenerator
    {
        private const int MaxPossibleAge = 100;

        public AgeRangeDataGenerator(IRandomDataGenerator randomDataGenerator, ToysStoreEntities toysStoreEntities, int generationsCount, ILogger logger)
            : base(randomDataGenerator, toysStoreEntities, generationsCount, logger)
        {
        }

        public override void Generate()
        {
            this.Logger.StartOfNotification("Generating AgeRanges!");

            int counter = 0;
            for (int i = 0; i < MaxPossibleAge; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    var ageRange = new AgeRanx
                    {
                        MinRange = j,
                        MaxRange = i,
                    };

                    this.Database.AgeRanges.Add(ageRange);

                    if (counter % 100 == 0)
                    {
                        this.Logger.NotifyProgress();
                        this.Database.SaveChanges();
                    }

                    counter++;
                    if (counter >= this.GenerationsCount)
                    {
                        this.Logger.EndOfNotification();
                        return;
                    }
                }
            }
        }
    }
}
