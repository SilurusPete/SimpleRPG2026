using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine1.Models;

namespace Engine1.Factories
{
    internal class WorldFactory
    {
        internal World CreateWorld()
        {
            World newWorld = new World();

            newWorld.AddLocation(-3, -1, "Bandit Camp",
                ".",
                "/Engine;component/Images/Locations/BanditCamp.png");

            newWorld.AddLocation(-2, -1, "Meadows",
                ".",
                "/Engine;component/Images/Locations/Meadows.png");

            newWorld.AddLocation(-1, -1, "Guard Camp",
                ".",
                "/Engine;component/Images/Locations/Guard'sOutpost.png");

            newWorld.AddLocation(0, -1, "Graveyard",
                ".",
                "/Engine;component/Images/Locations/Graveyard.png");

            newWorld.AddLocation(1, -1, "Dense forest with a barely visible path in sight",
                ".",
                "/Engine;component/Images/Locations/BarelyVisiblePath.png");

            newWorld.AddLocation(-1, 0, "Some local houses",
                ".",
                "/Engine;component/Images/Locations/InhabitedHouses.png");

            newWorld.AddLocation(0, 0, "Church",
                "The place you first appeared at with a quest in mind to bring peace in this world",
                "/Engine;component/Images/Locations/Church.png");

            newWorld.AddLocation(2, 2, "Barn",
                ".",
                "/Engine;component/Images/Locations/Barn.png");

            newWorld.AddLocation(2, -1, "Weird clearing in the forest",
                ".",
                "/Engine;component/Images/Locations/Cauldron.png");

            newWorld.AddLocation(-1, 1, "Town Square",
                ".",
                "/Engine;component/Images/Locations/TownSquare.png");

            newWorld.AddLocation(0, 1, "Market",
                ".",
                "/Engine;component/Images/Locations/Marketplace.png");

            newWorld.AddLocation(1, 1, "Farmer's house",
                ".",
                "/Engine;component/Images/Locations/Farmer'sHouse.png");

            newWorld.AddLocation(2, 1, "Farmer's field",
                ".",
                "/Engine;component/Images/Locations/Farmer'sField.png");

            newWorld.AddLocation(2, 0, "Strange hut at the outskirts",
                ".",
                "/Engine;component/Images/Locations/WitchHut.png");

            newWorld.AddLocation(-2, 1, "Herbalist's hut",
                ".",
                "/Engine;component/Images/Locations/Herbalist'sHut.png");

            newWorld.AddLocation(0, 2, "Weapon blacksmith's house",
                ".",
                "/Engine;component/Images/Locations/WeaponBlacksmith'sHouse.png");

            newWorld.AddLocation(-3, 1, "Herbs garden",
                ".",
                "/Engine;component/Images/Locations/HerbsGarden.png");

            return newWorld;
        }
    }
}
