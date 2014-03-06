using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradeAndTravel
{
    public class Wood : Item
    {

        private const int GeneralWoodValue = 2;

        public Wood(string name, Location location = null)
            : base(name, Wood.GeneralWoodValue, ItemType.Wood, location)
        {
        }

        public override void UpdateWithInteraction(string interaction)
        {
            switch (interaction)
            {
                case "drop":
                    this.HandleItemDrop();
                    break;
                default:
                    break;
            }

            base.UpdateWithInteraction(interaction);
        }

        private void HandleItemDrop()
        {
            if (this.Value > 0)
            {
                this.Value--;
            }
        }
    }
}
