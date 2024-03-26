using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    internal static class QuestFactory
    {
        private static readonly List<Quest> _quests = new List<Quest>();

        static QuestFactory()
        {
            List<ItemQuantity> itemsToComplete = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems = new List<ItemQuantity>();

            itemsToComplete.Add(new ItemQuantity(101, 1));
            rewardItems.Add(new ItemQuantity(102, 1));

            _quests.Add(new Quest(1,
                "Pesky Slimes",
                "Those slimes stole my sticks! Retrieve my sticks by slaying those pesky slimes and return the to me!",
                itemsToComplete,
                25, 10,
                rewardItems));
        }
        internal static Quest GetQuestByID(int id)
        {
            return _quests.FirstOrDefault(quest => quest.ID == id);
        }
    }
}
