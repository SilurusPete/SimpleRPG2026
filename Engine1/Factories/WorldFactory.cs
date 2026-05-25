using Engine.Factories;
using Engine1.Models;

namespace Engine1.Factories
{
    internal static class WorldFactory
    {
        internal static World CreateWorld()
        {
            World newWorld = new World();

            newWorld.AddLocation(-3, -1, "Bandit Camp",
                ".",
                "BanditCamp.png");

            newWorld.AddLocation(-2, -1, "Meadows",
                ".",
                "Meadows.png");
            newWorld.LocationAt(-2, -1).AddMonster(2, 80);
            newWorld.LocationAt(-2, -1).AddMonster(1, 20);

            newWorld.AddLocation(-1, -1, "Guard Camp",
                ".",
                "Guard'sOutpost.png");

            newWorld.AddLocation(0, -1, "Graveyard",
                ".",
                "Graveyard.png");

            newWorld.AddLocation(1, -1, "Dense forest with a barely visible path in sight",
                ".",
                "BarelyVisiblePath.png");
            newWorld.LocationAt(1, -1).AddMonster(3, 100);

            newWorld.AddLocation(-1, 0, "Some local houses",
                ".",
                "InhabitedHouses.png");
            newWorld.LocationAt(-1, 0).AddMonster(2, 20);

            newWorld.AddLocation(0, 0, "Church",
                "The place you first appeared at with a quest in mind to bring peace in this world",
                "Church.png");

            newWorld.AddLocation(2, 2, "Barn",
                ".",
                "Barn.png");

            newWorld.AddLocation(2, -1, "Weird clearing in the forest",
                ".",
                "Cauldron.png");

            newWorld.AddLocation(-1, 1, "Town Square",
                ".",
                "TownSquare.png");

            newWorld.AddLocation(0, 1, "Market",
                ".",
                "Marketplace.png");
            newWorld.LocationAt(0, 1).TraderHere = TraderFactory.GetTraderByName("Susan");

            newWorld.AddLocation(1, 1, "Farmer's house",
                ".",
                "Farmer'sHouse.png");
            newWorld.LocationAt(1, 1).TraderHere = TraderFactory.GetTraderByName("Farmer Ted");

            newWorld.AddLocation(2, 1, "Farmer's field",
                ".",
                "Farmer'sField.png");
            newWorld.LocationAt(-2, -1).AddMonster(2, 50);

            newWorld.AddLocation(2, 0, "Strange hut at the outskirts",
                ".",
                "WitchHut.png");

            newWorld.AddLocation(-2, 1, "Herbalist's hut",
                ".",
                "Herbalist'sHut.png");
            newWorld.LocationAt(-2, 1).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(1));
            newWorld.LocationAt(-2, 1).TraderHere = TraderFactory.GetTraderByName("Pete the Herbalist");

            newWorld.AddLocation(0, 2, "Weapon blacksmith's house",
                ".",
                "WeaponBlacksmith'sHouse.png");

            newWorld.AddLocation(-3, 1, "Herbs garden",
                ".",
                "HerbsGarden.png");
            newWorld.LocationAt(-3, 1).AddMonster(1, 100);

            return newWorld;
        }
    }
}
