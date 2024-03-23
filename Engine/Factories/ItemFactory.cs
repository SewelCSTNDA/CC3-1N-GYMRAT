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
        private static List<GameItem> _standardGameItems;

        static ItemFactory()
        {
            _standardGameItems = new List<GameItem>();

            _standardGameItems.Add(new Weapon(001, "Blunt Sword", 10, 4, 6));
            _standardGameItems.Add(new Weapon(002, "Iron Sword", 50, 10, 12));
        }

        public static GameItem CreateGameItem(int itemTypeId)
        {
            GameItem standardItem = _standardGameItems.FirstOrDefault(item => item.ItemTypeId == itemTypeId);

            if(standardItem != null)
            {
                return standardItem.Clone();
            }

            return null;
        }
    }
}
