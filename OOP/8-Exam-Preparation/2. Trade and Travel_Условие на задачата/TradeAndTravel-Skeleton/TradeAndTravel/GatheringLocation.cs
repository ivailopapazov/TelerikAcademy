using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradeAndTravel
{
    public abstract class GatheringLocation : Location, IGatheringLocation
    {
        protected GatheringLocation(string name, LocationType locationType, ItemType gatheredType, ItemType requiredType)
            : base(name, locationType)
        {
            this.GatheredType = gatheredType;
            this.RequiredItem = requiredType;
        }

        public ItemType GatheredType
        {
            get;
            private set;
        }

        public ItemType RequiredItem
        {
            get;
            private set;
        }

        public abstract Item ProduceItem(string name);
    }
}
