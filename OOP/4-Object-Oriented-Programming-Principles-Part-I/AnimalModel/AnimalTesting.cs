using System;
using System.Collections.Generic;
using System.Linq;

namespace AnimalModel
{
    class AnimalTesting
    {
        static void Main()
        {
            // Initialize list of animals
            List<Animal> animals = new List<Animal>() 
            { 
                new Kitten(1, "Sisi"),
                new Tomcat(1, "Tommy"),
                new Cat(4, "male", "Chochi"),
                new Dog(10, "female", "Sara"),
                new Frog(2, "male", "Joro"),
                new Cat(8, "female", "Misi"),
                new Dog(3, "male", "Roko"),
                new Frog(3, "female", "Jana"),
                new Kitten(2, "Snowbow"),
                new Tomcat(2, "Richard"),
                new Dog(5, "male", "Sharo"),
                new Dog(12, "male", "Balkan"),
            };

            // Extract each animal group with the avarage age of it's members 
            var animalGroups = 
                from animal in animals
                group animal by animal.GetType() into groupedAnimals
                select new 
                {
                    Name = groupedAnimals.Key.ToString(),
                    AverageAge = groupedAnimals.Average(animal => animal.Age)
                };


            // Print result
            foreach (var animalGroup in animalGroups)
            {
                Console.WriteLine("{0} avarage age: {1}", animalGroup.Name, animalGroup.AverageAge);
            }
        }
    }
}
