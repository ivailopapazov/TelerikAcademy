namespace KnapSack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Wintellect.PowerCollections;

    internal class Program
    {
        static void Main()
        {
            int capacity = int.Parse(Console.ReadLine());
            int foodCount = int.Parse(Console.ReadLine());
            List<Food> foods = new List<Food>();
            List<Food> stomach = new List<Food>();

            for (int i = 0; i < foodCount; i++)
            {
                var food = Console.ReadLine().Split(' ');
                foods.Add(new Food(food[0], int.Parse(food[1]), int.Parse(food[2]), i));
            }

            var orderedFoods = foods.OrderByDescending(food => food.Ratio).ToList();

            int currentCapacity = 0;
            int currentDeliciousness = 0;
            foreach (var food in orderedFoods)
            {
                if (food.Weight + currentCapacity <= capacity)
                {
                    stomach.Add(food);
                    currentCapacity += food.Weight;
                    currentDeliciousness += food.Deliciousness;
                }
            }

            Console.WriteLine(currentDeliciousness);
            foreach (var food in stomach.OrderByDescending(f => f.Number))
            {
                Console.WriteLine(food.Name);
            }
        }
    }

    internal class Food
    {
        public Food(string name, int weight, int deliciousness, int number)
        {
            this.Name = name;
            this.Weight = weight;
            this.Deliciousness = deliciousness;
            this.Ratio = (double)deliciousness / weight;
            this.Number = number;
        }

        public string Name { get; set; }

        public int Deliciousness { get; set; }

        public int Weight { get; set; }

        public double Ratio { get; set; }

        public int Number { get; set; }
    }
}
