using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheffClassRefactor
{
    class Bowl
    {
        private List<Vegetable> vegetablesInBowl;
        
        public Bowl()
        {
            this.vegetablesInBowl = new List<Vegetable>();
        }
        
        public void Add(Vegetable vegetable)
        {
            vegetablesInBowl.Add(vegetable);
        }
    }
}
