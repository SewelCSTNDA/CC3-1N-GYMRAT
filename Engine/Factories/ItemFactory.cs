using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    public static class ItemFactory
    {
        private static readonly List<GameItem> _standardGameItems = new List<GameItem>();

        static ItemFactory()
        {
            _standardGameItems = new List<GameItem>();
            _standardGameItems.Add(new Weapon(001, "Fledgling Sword", 5, 15, 20));
            _standardGameItems.Add(new Weapon(002, "Novice Longsword", 40, 60, 75));
            _standardGameItems.Add(new Weapon(003, "Veteran Claymore", 100, 230, 250));
            _standardGameItems.Add(new Weapon(004, "Novice Bow", 25, 60, 80));
            _standardGameItems.Add(new Weapon(005, "Crimson Bow", 45, 200, 225));
            _standardGameItems.Add(new GameItem(006, "Stick", 1));
            _standardGameItems.Add(new GameItem(007, "Stone", 1));
            _standardGameItems.Add(new GameItem(008, "Slime glue", 1));
            _standardGameItems.Add(new GameItem(029, "Size S- Elixir of Fortitude ", 1));//29
            _standardGameItems.Add(new GameItem(009, "Size M- Elixir of Fortitude ", 2));
            _standardGameItems.Add(new GameItem(030, "Size L- Elixir of Fortitude ", 3));//30
            _standardGameItems.Add(new GameItem(010, "Leaf", 1));
            _standardGameItems.Add(new GameItem(011, "Pebble", 1));
            _standardGameItems.Add(new Weapon(012, "Everia’s Edge(Legendary)", 1000, 300, 500));
            _standardGameItems.Add(new Weapon(013, "Iron hammer with Enchanted Gemstones(Legendary)", 1200, 100, 125));
            _standardGameItems.Add(new Weapon(014, "BADLUCK’s Grimoire(Mythic)", 0, 696, 969));
            _standardGameItems.Add(new Weapon(015, "Shadow Bane Dagger(Legendary)", 1100, 200, 225));
            _standardGameItems.Add(new GameItem(016, "Amulet for Warding(Rare)", 150));
            _standardGameItems.Add(new GameItem(017, "Knowledge of the Shadow(Rare)", 250));
            _standardGameItems.Add(new GameItem(018, "Oracle’s Guidance(Legendary)", 300));
            _standardGameItems.Add(new GameItem(019, "Map of Hidden Paths(Rare)", 200));
            _standardGameItems.Add(new GameItem(020, "Elixir of Clarity(Uncommon)", 20));
            _standardGameItems.Add(new GameItem(021, "Crystal Slime gel", 2));
            _standardGameItems.Add(new Weapon(022, "Vixen's Sword", 50, 80, 100));
            _standardGameItems.Add(new Weapon(023, "Gromble's Club", 50, 120, 150));
            _standardGameItems.Add(new Weapon(024, "Solin's Knight Edge", 50, 320, 400));
            _standardGameItems.Add(new Weapon(025, "Aaron's Shines", 50, 420, 690));
            _standardGameItems.Add(new GameItem(026, "Vixen's Helm", 50));
            _standardGameItems.Add(new GameItem(027, "Goblin Ear", 1));
            _standardGameItems.Add(new GameItem(028, "Crystal Shards", 2));
            //meron na 29 nasa line 25
            //meron na 30 nasa line 26

        }

        public static GameItem CreateGameItem(int itemTypeId)
        {
            GameItem standardItem = _standardGameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeId);

            if(standardItem != null)
            {
                if (standardItem is Weapon)
                {
                    return (standardItem as Weapon).Clone();
                }

                return standardItem.Clone();

            }

            return null;
        }
    }
}
