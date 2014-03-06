using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradeAndTravel
{
    public class ExtendedInteractionManager : InteractionManager
    {

        public ExtendedInteractionManager()
            : base()
        {
        }

        protected override Item CreateItem(string itemTypeString, string itemNameString, Location itemLocation, Item item)
        {
            switch (itemTypeString)
            {
                case "weapon":
                    item = new Weapon(itemNameString, itemLocation);
                    break;
                case "wood":
                    item = new Wood(itemNameString, itemLocation);
                    break;
                case "iron":
                    item = new Iron(itemNameString, itemLocation);
                    break;
                default:
                    return base.CreateItem(itemTypeString, itemNameString, itemLocation, item);
            }

            return item;
        }

        protected override Location CreateLocation(string locationTypeString, string locationName)
        {
            Location location = null;

            switch (locationTypeString)
            {
                case "mine":
                    location = new Mine(locationName);
                    break;
                case "forest":
                    location = new Forest(locationName);
                    break;
                default:
                    return base.CreateLocation(locationTypeString, locationName);
            }

            return location;
        }

        protected override void HandlePersonCommand(string[] commandWords, Person actor)
        {
            switch (commandWords[1])
            {
                case "gather":
                    HnadleGatherInteraction(commandWords[2], actor);
                    break;
                case "craft":
                    HandleCraftInteraction(commandWords[2], commandWords[3], actor);
                    break;
                default:
                    base.HandlePersonCommand(commandWords, actor);
                    break;
            }

        }

        private void HandleCraftInteraction(string craftedItemType, string craftedItemName, Person actor)
        {
            // Get inventory list
            var actorInventory = actor.ListInventory();

            // Get recipe
            List<ItemType> recipe = Item.GetRecipe(craftedItemType);

            // Container for ingredients
            List<Item> requiredItems = new List<Item>();

            // Get required item from actor's inventory
            foreach (var requiredItemType in recipe)
	        {
                var requiredItem = actorInventory
                .Find((item) => item.ItemType == requiredItemType);

                if (requiredItem != null)
                {
                    requiredItems.Add(requiredItem);
                }
	        }

            // Check if all required ingredients are in the inventory
            if (requiredItems.Count != recipe.Count)
            {
                return;
            }

            // Remove ingredients from inventory
            //requiredItems.ForEach((item) => this.RemoveFromPerson(actor, item));

            // Add crafted item to inventory
            switch (craftedItemType)
            {
                case "armor":
                    this.AddToPerson(actor, new Armor(craftedItemName));
                    break;
                case "weapon":
                    this.AddToPerson(actor, new Weapon(craftedItemName));
                    break;
                default:
                    break;
            }
        }

        private void HnadleGatherInteraction(string gatheredItemName, Person actor)
        {
            // Check location if is IGatheringLocation
            IGatheringLocation currentLocation = actor.Location as IGatheringLocation;
            if (currentLocation == null)
            {
                return;
            }

            // Check if actor has required item
            var actorInventory = actor.ListInventory();
            var actorHasRequiredItem = actorInventory
                .Any((item) => item.ItemType == currentLocation.RequiredItem);

            if (actorHasRequiredItem)
            {
                // Gather item
                var gatheredItem = currentLocation.ProduceItem(gatheredItemName);

                // Add new item to the actor's inventory
                this.AddToPerson(actor, gatheredItem);
            }
        }

        protected override Person CreatePerson(string personTypeString, string personNameString, Location personLocation)
        {
            Person person = null;

            switch (personTypeString)
            {
                case "merchant":
                    person = new Merchant(personNameString, personLocation);
                    break;
                default:
                    return base.CreatePerson(personTypeString, personNameString, personLocation);
            }

            return person;
        }
    }
}
