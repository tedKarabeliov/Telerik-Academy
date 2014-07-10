using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAndTravel
{
    public class Wood : Item
    {
        const int GeneralWoodValue = 2;

        public Wood(string itemNameString, Location itemLocation)
            : base(itemNameString, Wood.GeneralWoodValue, ItemType.Wood, itemLocation) { }

        public override void UpdateWithInteraction(string interaction)
        {
            //TODO, Check for wood drop
            base.UpdateWithInteraction(interaction);
        }
    }
}
