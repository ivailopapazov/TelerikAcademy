namespace ToysStore.RandomDataGenerator.Tools
{
    using System;
    using ToysStore.RandomDataGenerator.Contracts;

    internal class RandomDataGenerator : IRandomDataGenerator
    {
        private const string Letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        private static IRandomDataGenerator randomDataGenerator;
        private readonly Random random;

        private RandomDataGenerator()
        {
            this.random = new Random();
        }

        public static IRandomDataGenerator Instance
        {
            get
            {
                if (randomDataGenerator == null)
                {
                    randomDataGenerator = new RandomDataGenerator();
                }

                return randomDataGenerator;
            }
        }

        public int GetRandomNumber(int min, int max)
        {
            return this.random.Next(min, max);
        }

        public string GetRandomString(int length)
        {
            char[] result = new char[length];

            for (int i = 0; i < result.Length; i++)
            {
                int randomLetterIndex = this.GetRandomNumber(0, Letters.Length);
                result[i] = Letters[randomLetterIndex];
            }

            return new string(result);
        }

        public string GetRandomStringWithRandomLength(int min, int max)
        {
            return this.GetRandomString(this.GetRandomNumber(min, max));
        }
    }
}
