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

            //Oracle
            itemsToComplete.Add(new ItemQuantity(006, 10));
            itemsToComplete.Add(new ItemQuantity(007, 10));
            itemsToComplete.Add(new ItemQuantity(010, 10));
            itemsToComplete.Add(new ItemQuantity(011, 10));
            rewardItems.Add(new ItemQuantity(018, 1));
            _quests.Add(new Quest(00,
                "Oracle's Guide",
                "Gather me 10 each of resources in your sorroundings.",
                itemsToComplete,
                100, 10,
                rewardItems));

            //Slime
            itemsToComplete.Add(new ItemQuantity(008, 10));
            rewardItems.Add(new ItemQuantity(020, 1));
            _quests.Add(new Quest(01,
                "Pesky Slimes",
                "Those slimes stole my sticks! Retrieve my sticks by slaying those pesky slimes and return the to me!",
                itemsToComplete,
                10, 2,
                rewardItems));

            //Crystal Slime
            itemsToComplete.Add(new ItemQuantity(021, 10));
            rewardItems.Add(new ItemQuantity(013, 1));
            _quests.Add(new Quest(02,
            "Crystal Gels",
            "Kill Crystalize Slimes and gather 10 of their drop gels.",
            itemsToComplete,
            25, 4,
            rewardItems));

            //Vixen
            itemsToComplete.Add(new ItemQuantity(022, 1));
            itemsToComplete.Add(new ItemQuantity(026, 1));
            rewardItems.Add(new ItemQuantity(020, 1));
            _quests.Add(new Quest(03,
            "Vixen's Raiding Post",
            "Annihilate Vixen's group raid and get its sword and helmet.",
            itemsToComplete,
            100, 10,
            rewardItems));

            //Gromble
            itemsToComplete.Add(new ItemQuantity(023, 1));
            rewardItems.Add(new ItemQuantity(023, 1));
            _quests.Add(new Quest(04,
            "Gromble Hut",
            "Destroy the Goblin's Chief to scare the goblins.",
            itemsToComplete,
            250, 15,
            rewardItems));

            //Solin
            itemsToComplete.Add(new ItemQuantity(024, 1));
            rewardItems.Add(new ItemQuantity(015, 1));
            _quests.Add(new Quest(05,
            "Solin's Realm",
            "Free the Arcane Village from the Shadows of Solin by getting his sword. ",
            itemsToComplete,
            500, 50,
            rewardItems));

            //Aaron
            itemsToComplete.Add(new ItemQuantity(025, 1));
            rewardItems.Add(new ItemQuantity(025, 1));
            _quests.Add(new Quest(06,
            "Aaron's Shrine",
            "Get the throne for yourself to make your island safe and peaceful.",
            itemsToComplete,
            1000, 100,
            rewardItems));

            //EasterEgg
            itemsToComplete.Add(new ItemQuantity(006, 69));
            itemsToComplete.Add(new ItemQuantity(007, 69));
            itemsToComplete.Add(new ItemQuantity(010, 69));
            itemsToComplete.Add(new ItemQuantity(011, 69));
            itemsToComplete.Add(new ItemQuantity(021, 69));
            rewardItems.Add(new ItemQuantity(014, 1));
            _quests.Add(new Quest(69,
            "GALBITOTOTOO",
            "69 RESOURCES EACHHH",
            itemsToComplete,
            69, 69,
            rewardItems));

        }
        internal static Quest GetQuestByID(int id)
        {
            return _quests.FirstOrDefault(quest => quest.ID == id);
        }
    }
}