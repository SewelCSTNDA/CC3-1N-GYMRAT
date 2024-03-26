using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    public static class MonsterFactory
    {
        public static Monster GetMonster(int monsterID)
        {
            switch (monsterID)
            {
                case 1:

                    Monster slime = new Monster("Slime", "Slime.png", 4, 4, 1, 2, 5, 1);

                    AddLootItem(slime, 101, 75);
                    AddLootItem(slime, 102, 25);

                    return slime;

                case 2:

                    Monster cslime = new Monster("Crystal Slime", "Crystal Slime.png", 5, 5, 2, 3, 5, 1);

                    AddLootItem(cslime, 103, 25);
                    AddLootItem(cslime, 104, 75);

                    return cslime;   
                    
                case 3:

                    Monster goblin = new Monster("Goblin", "Orc.png", 10, 10, 4, 5, 10, 3);

                    AddLootItem(goblin, 101, 25);
                    AddLootItem(goblin, 102, 75);

                    return goblin;

                default:

                    throw new ArgumentException(string.Format("MonsterType '{0}' does not exist", monsterID));

            }
        }

        private static void AddLootItem(Monster monster, int itemID, int percentage)
        {
            if (RandomNumberGenerator.NumberBetween(1, 100) <= percentage)
            {
                monster.Inventory.Add(new ItemQuantity(itemID, 1));
            }
        }
    }
}
