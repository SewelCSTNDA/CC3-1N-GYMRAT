using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;
using Engine.Actions;

namespace Engine.Factories
{
    public static class ItemFactory
    {
        private static readonly List<GameItem> _standardGameItems = new List<GameItem>();

        static ItemFactory()
        {
            BuildWeapon(001, "Fledgling Sword", 5, 15, 20);
            BuildWeapon(002, "Novice Longsword", 40, 60, 75);
            BuildWeapon(003, "Veteran Claymore", 100, 230, 250);
            BuildWeapon(004, "Novice Bow", 25, 60, 80);
            BuildWeapon(005, "Crimson Bow", 45, 200, 225);
            BuildMiscellaneousItem(006, "Stick", 1);
            BuildMiscellaneousItem(007, "Stone", 1);
            BuildMiscellaneousItem(008, "Slime glue", 1);
            BuildMiscellaneousItem(029, "Size S- Elixir of Fortitude ", 1);//29
            BuildMiscellaneousItem(009, "Size M- Elixir of Fortitude ", 2);
            BuildMiscellaneousItem(030, "Size L- Elixir of Fortitude ", 3);//30
            BuildMiscellaneousItem(010, "Leaf", 1);
            BuildMiscellaneousItem(011, "Pebble", 1);
            BuildWeapon(012, "Everia’s Edge(Legendary)", 1000, 300, 500);
            BuildWeapon(013, "Iron hammer with Enchanted Gemstones(Legendary)", 1200, 100, 125);
            BuildWeapon(014, "BADLUCK’s Grimoire(Mythic)", 0, 696, 969);
            BuildWeapon(015, "Shadow Bane Dagger(Legendary)", 1100, 200, 225);
            BuildMiscellaneousItem(016, "Amulet for Warding(Rare)", 150);
            BuildMiscellaneousItem(017, "Knowledge of the Shadow(Rare)", 250);
            BuildMiscellaneousItem(018, "Oracle’s Guidance(Legendary)", 300);
            BuildMiscellaneousItem(019, "Map of Hidden Paths(Rare)", 200);
            BuildMiscellaneousItem(020, "Elixir of Clarity(Uncommon)", 20);
            BuildMiscellaneousItem(021, "Crystal Slime gel", 2);
            BuildWeapon(022, "Vixen's Sword", 50, 80, 100);
            BuildWeapon(023, "Gromble's Club", 50, 120, 150);
            BuildWeapon(024, "Solin's Knight Edge", 50, 320, 400);
            BuildWeapon(025, "Aaron's Shines", 50, 420, 690);
            BuildMiscellaneousItem(026, "Vixen's Helm", 50);
            BuildMiscellaneousItem(027, "Goblin Ear", 1);
            BuildMiscellaneousItem(028, "Crystal Shards", 2);
            //meron na 29 nasa line 25
            //meron na 30 nasa line 26

        }

        public static GameItem CreateGameItem(int itemTypeId)
        {
            return _standardGameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeId)?.Clone();
        }

        private static void BuildMiscellaneousItem(int id, string name, int price)
        {
            _standardGameItems.Add(new GameItem(GameItem.ItemCategory.Miscellaneous, id, name, price));
        }
        private static void BuildWeapon(int id, string name, int price,
                                        int minimumDamage, int maximumDamage)
        {
            GameItem weapon = new GameItem(GameItem.ItemCategory.Weapon, id, name, price, true);
            weapon.Action = new AttackWithWeapon(weapon, minimumDamage, maximumDamage);
            _standardGameItems.Add(weapon);
        }
    }
}
