using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAndTravel
{
    public class Iron : Item
    {
        const int GeneralIronValue = 3;

        public Iron(string itemNameString, Location itemLocation)
            : base(itemNameString, Iron.GeneralIronValue, ItemType.Iron, itemLocation) { }
    }
}
