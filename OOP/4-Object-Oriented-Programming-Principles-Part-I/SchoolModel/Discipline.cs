using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolModel
{
    public class Discipline : SchoolObject
    {
        public Discipline(string name, int lectures, int exercises)
        {
            this.Name = name;
            this.NumberOfExercises = lectures;
            this.NumberOfExercises = exercises;
        }

        public string Name { get; private set; }
        public int NumberOfLectures { get; private set; }
        public int NumberOfExercises { get; private set; }
    }
}
