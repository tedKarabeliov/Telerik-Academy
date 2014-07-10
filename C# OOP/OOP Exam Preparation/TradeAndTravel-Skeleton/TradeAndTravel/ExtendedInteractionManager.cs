using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAndTravel
{
    public class ExtendedInteractionManager : InteractionManager
    {
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
                    HandleGatherInteraction(commandWords, actor);
                    break;
                case "craft":
                    HandleCraftInteraction(commandWords, actor);
                    break;
                default:
                    base.HandlePersonCommand(commandWords, actor);
                    break;
            }
        }

        private void HandleGatherInteraction(string[] commandWords, Person actor)
        {
            if (actor.Location.LocationType == LocationType.Mine)
            {
                foreach (var item in actor.ListInventory())
                {
                    if (item is Armor)
                    {
                        AddToPerson(actor, new Iron(commandWords[2], actor.Location));
                    }
                }
            }
            else if (actor.Location.LocationType == LocationType.Forest)
            {
                foreach (var item in actor.ListInventory())
                {
                    if (item is Weapon)
                    {
                        AddToPerson(actor, new Wood(commandWords[2], actor.Location));
                    }
                }
            }
        }

        private void HandleCraftInteraction(string[] commandWords, Person actor)
        {
            bool hasIron = false;
            bool hasWood = false;
            foreach (var item in actor.ListInventory())
            {
                if (item is Iron)
                {
                    hasIron = true;
                }
                if (item is Wood)
                {
                    hasWood = true;
                }
            }
            if (hasIron && hasWood)
            {
                AddToPerson(actor, new Weapon(commandWords[3], actor.Location));
            }
            else if (hasIron)
            {
                AddToPerson(actor, new Armor(commandWords[3], actor.Location));
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
