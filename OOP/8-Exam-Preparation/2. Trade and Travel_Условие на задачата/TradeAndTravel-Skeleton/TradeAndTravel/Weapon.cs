using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradeAndTravel
{
    public class Weapon : Item
    {
        private const int GeneralArmorValue = 10;

        public Weapon(string name, Location location = null)
            : base(name, GeneralArmorValue, ItemType.Weapon, location)
        {
        }
    }
}
