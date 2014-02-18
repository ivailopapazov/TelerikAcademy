using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolModel
{
    public class Teacher : Person
    {
        public Teacher(string name)
            : this(name, null)
        {
        }

        public Teacher(string name, IEnumerable<Discipline> disciplines)
            : base(name)
        {
            this.Disciplines = disciplines.ToList();
        }

        public List<Discipline> Disciplines { get; private set; }
    }
}
