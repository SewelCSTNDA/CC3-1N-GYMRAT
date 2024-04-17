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
                    AddLootItem(slime, 008, 100);
                    AddLootItem(slime, 006, 25);
                    AddLootItem(slime, 007, 25);
                    AddLootItem(slime, 010, 25);
                    AddLootItem(slime, 011, 25);
                    return slime;

                case 2:
                    Monster cslime = new Monster("Crystal Slime", "Crystal Slime.png", 5, 5, 2, 3, 5, 1);
                    AddLootItem(cslime, 028, 5);
                    AddLootItem(cslime, 021, 95);
                    return cslime;   
                    
                case 3:
                    Monster goblin = new Monster("Goblin", "Orc.png", 10, 10, 4, 5, 10, 3);
                    AddLootItem(goblin, 027, 100);
                    return goblin;

                case 4:
                    Monster gromble = new Monster("Gromble", "Gromble.png", 550, 500, 70, 90, 200, 20);
                    AddLootItem(gromble, 023, 100);
                    return gromble;

                case 5:
                    Monster vixen = new Monster("Vixen", "Vixen.png", 400, 369, 30, 35, 50, 5);
                    AddLootItem(vixen, 022, 95);
                    AddLootItem(vixen, 026, 5);
                    return vixen;

                case 6:
                    Monster solin = new Monster("Solin", "Solin.png", 1500, 1500, 120, 170, 750, 70);
                    AddLootItem(solin, 024, 100);
                    return solin;

                case 7:
                    Monster aaron = new Monster("Aaron", "Aaron.png", 3000, 2900, 200, 300, 1250, 150);
                    AddLootItem(aaron, 024, 100);
                    return aaron;

                default:
                    throw new ArgumentException(string.Format("MonsterType '{0}' does not exist", monsterID));
            }
        }

        private static void AddLootItem(Monster monster, int itemID, int percentage)
        {
            if (RandomNumberGenerator.NumberBetween(1, 100) <= percentage)
            {
                monster.AddItemToInventory(ItemFactory.CreateGameItem(itemID));
            }
        }
    }
}
