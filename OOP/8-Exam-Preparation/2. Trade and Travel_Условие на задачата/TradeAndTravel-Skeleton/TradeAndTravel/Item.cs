using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradeAndTravel
{
    public abstract class Item : WorldObject
    {
        public ItemType ItemType { get; private set; }

        public int Value { get; protected set; }

        protected Item(string name, int itemValue, string type, Location location = null)
            : base(name)
        {
            this.Value = itemValue;

            foreach (var itemType in (ItemType[])Enum.GetValues(typeof(ItemType)))
            {
                if (itemType.ToString() == type)
                {
                    this.ItemType = itemType;
                }
            }
        }

        protected Item(string name, int itemValue, ItemType type, Location location = null)
            : base(name)
        {
            this.Value = itemValue;
            this.ItemType = type;
        }

        public static List<ItemType> GetRecipe(string item) 
        {
            Dictionary<string, List<ItemType>> recipeBook = new Dictionary<string, List<ItemType>>()
            {
                { "armor" , new List<ItemType>() { ItemType.Iron }},
                { "weapon" , new List<ItemType>() { ItemType.Iron, ItemType.Wood }},
            };

            return recipeBook[item];
        }

        public virtual void UpdateWithInteraction(string interaction)
        {
        }
    }
}
