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

                    Monster slime = new Monster("Slime", "Slime.png", 4, 4, 5, 10);

                    slime.CurrentWeapon = ItemFactory.CreateGameItem(100);

                    AddLootItem(slime, 008, 100);
                    AddLootItem(slime, 006, 25);
                    AddLootItem(slime, 007, 25);
                    AddLootItem(slime, 010, 25);
                    AddLootItem(slime, 011, 25);
                    return slime;

                case 2:
                    Monster cslime = new Monster("Crystal Slime", "Crystal Slime.png", 5, 5, 5, 1);

                    cslime.CurrentWeapon = ItemFactory.CreateGameItem(100);

                    AddLootItem(cslime, 028, 5);
                    AddLootItem(cslime, 021, 95);
                    return cslime;   
                    
                case 3:
                    Monster goblin = new Monster("Goblin", "Orc.png", 10, 10, 10, 3);

                    goblin.CurrentWeapon = ItemFactory.CreateGameItem(101);

                    AddLootItem(goblin, 027, 100);
                    return goblin;

                case 4:
                    Monster gromble = new Monster("Gromble", "Gromble.png", 550, 500, 200, 20);

                    gromble.CurrentWeapon = ItemFactory.CreateGameItem(102);

                    AddLootItem(gromble, 023, 100);
                    return gromble;

                case 5:
                    Monster vixen = new Monster("Vixen", "Vixen.png", 400, 369, 50, 5);

                    vixen.CurrentWeapon = ItemFactory.CreateGameItem(102);

                    AddLootItem(vixen, 022, 95);
                    AddLootItem(vixen, 026, 5);
                    return vixen;

                case 6:
                    Monster solin = new Monster("Solin", "Solin.png", 1500, 1500, 750, 70);

                    solin.CurrentWeapon = ItemFactory.CreateGameItem(102);

                    AddLootItem(solin, 024, 100);
                    return solin;

                case 7:
                    Monster aaron = new Monster("Aaron", "Aaron.png", 3000, 2900, 1250, 150);

                    aaron.CurrentWeapon = ItemFactory.CreateGameItem(102);

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
