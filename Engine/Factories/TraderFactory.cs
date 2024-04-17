using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    public static class TraderFactory
    {
        private static readonly List<Trader> _traders = new List<Trader>();
        static TraderFactory()
        {
            //SUSAN - Advance items
            Trader susan = new Trader("Susan");
            susan.AddItemToInventory(ItemFactory.CreateGameItem(003));
            susan.AddItemToInventory(ItemFactory.CreateGameItem(005));
            susan.AddItemToInventory(ItemFactory.CreateGameItem(029));
            susan.AddItemToInventory(ItemFactory.CreateGameItem(009));
            susan.AddItemToInventory(ItemFactory.CreateGameItem(030));
            susan.AddItemToInventory(ItemFactory.CreateGameItem(31));
            susan.AddItemToInventory(ItemFactory.CreateGameItem(32));
            susan.AddItemToInventory(ItemFactory.CreateGameItem(33));

            //TED - Resources seller
            Trader farmerTed = new Trader("Farmer Ted");
            farmerTed.AddItemToInventory(ItemFactory.CreateGameItem(006));
            farmerTed.AddItemToInventory(ItemFactory.CreateGameItem(007));
            farmerTed.AddItemToInventory(ItemFactory.CreateGameItem(010));
            farmerTed.AddItemToInventory(ItemFactory.CreateGameItem(011));

            //PETE - Beginner items
            Trader peteTheHerbalist = new Trader("Pete the Herbalist");
            peteTheHerbalist.AddItemToInventory(ItemFactory.CreateGameItem(004));
            peteTheHerbalist.AddItemToInventory(ItemFactory.CreateGameItem(001));
            peteTheHerbalist.AddItemToInventory(ItemFactory.CreateGameItem(029));
            peteTheHerbalist.AddItemToInventory(ItemFactory.CreateGameItem(008));
            AddTraderToList(susan);
            AddTraderToList(farmerTed);
            AddTraderToList(peteTheHerbalist);
        }
        public static Trader GetTraderByName(string name)
        {
            return _traders.FirstOrDefault(t => t.Name == name);
        }
        private static void AddTraderToList(Trader trader)
        {
            if (_traders.Any(t => t.Name == trader.Name))
            {
                throw new ArgumentException($"There is already a trader named '{trader.Name}'");
            }
            _traders.Add(trader);
        }
    }
}
