namespace ToysStore.RandomDataGenerator.DataGenerators
{
    using ToysStore.Data;
    using ToysStore.RandomDataGenerator.Contracts;

    internal abstract class DataGenerator : IDataGenerator
    {
        public DataGenerator(IRandomDataGenerator randomDataGenerator, ToysStoreEntities toysStoreEntities, int generationsCount, ILogger logger)
        {
            this.RandomDataGenerator = randomDataGenerator;
            this.Database = toysStoreEntities;
            this.GenerationsCount = generationsCount;
            this.Logger = logger;
        }

        protected IRandomDataGenerator RandomDataGenerator { get; private set; }

        protected ToysStoreEntities Database { get; private set; }

        protected int GenerationsCount { get; private set; }

        protected ILogger Logger { get; private set; }

        public abstract void Generate();
    }
}
