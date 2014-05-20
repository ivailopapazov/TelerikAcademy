using System;

class HumanWraper
{
    enum Sex
    {
        Male,
        Female
    };

    class Human
    {
        public Sex Sex { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public void CreateHuman(int magicNumber)
    {
        Human human = new Human();
        human.Age = magicNumber;
        if (magicNumber % 2 == 0)
        {
            human.Name = "Батката";
            human.Sex = Sex.Male;
        }
        else
        {
            human.Name = "Мацето";
            human.Sex = Sex.Female;
        }
    }
}

// I don't have any idea what I'm supposed to do here!