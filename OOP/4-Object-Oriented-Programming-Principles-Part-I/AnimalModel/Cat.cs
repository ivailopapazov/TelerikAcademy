using System;
using System.Linq;

namespace AnimalModel
{
    /// <summary>
    /// Represents cat animal.
    /// </summary>
    class Cat : Animal
    {
        /// <summary>
        /// Initializes new instance of the cat class to the specified age, sex and name of the cat.
        /// </summary>
        /// <param name="age">Cat's age</param>
        /// <param name="sex">Cat's sex</param>
        /// <param name="name">Cat's name</param>
        public Cat(int age, string sex, string name)
            : base(age, sex, name)
        {
        }

        /// <summary>
        /// Makes the animal to produce it's own sound.
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine("meow");
        }
    }
}
