using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal class WorldFactory
    {
        internal static World CreateWorld()
        {
            World newWorld = new World();

            /** Oracle's Refuge **/
            newWorld.AddLocation(0, 0, "Oracle's Refuge", "This is the place where you will be guided by a spirit.", "OracleCastle.jpg");
            newWorld.LocationAt(0, 0).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(00));//oracle quest
            newWorld.LocationAt(0, 0).TraderHere = TraderFactory.GetTraderByName("Pete the Herbalist");

            /** Slime Field**/
            newWorld.AddLocation(1, 0, "Slime Field", "This area full of harmful slimes.", "GrassField1.jpg");
            newWorld.LocationAt(1, 0).AddMonster(1, 100);//slime
            newWorld.AddLocation(1, -1, "Village of Whispering Pines", "This place is full of villagers where you can get cool items.", "Village1.jpg");
            newWorld.LocationAt(1, -1).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(01));//slime quest
            newWorld.LocationAt(1, -1).TraderHere = TraderFactory.GetTraderByName("Farmer Ted");

            //Crystal Mine
            newWorld.AddLocation(1, -2, "Cryztalize Mineshaft", "This area is full of crystals and crystalized enemy", "CrystalMS.jpg");
            newWorld.LocationAt(1, -2).AddMonster(2, 100);//crsytal slime

            //Vixen raid first before Crystal 
            newWorld.AddLocation(2, -1, "Grassfield", "This place is filled with human size grasses.", "GrassField2.jpg");
            newWorld.LocationAt(2, -1).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(03)); //vixen quest
            newWorld.AddLocation(2, 0, "Vexen's Raid", "This place is where Vexen's starting his move to raid the castle.", "VexenRaid.jpg");
            newWorld.LocationAt(2, 0).AddMonster(5, 100);//vixen

            //Crystal Quest
            newWorld.AddLocation(2, 1, "Castle of Misty Gold", "This place is a trader's area where you can buy and sell stuff and many more.", "Castle1.jpg");
            newWorld.LocationAt(2, 1).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(02));//crystal slime quest
            newWorld.LocationAt(2, 1).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(04));//gromble quest

            //Easter egg
            newWorld.AddLocation(1, 1, "69", "69", "EasterEgg.png");
            newWorld.LocationAt(1, 1).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(69));//easter quest

            //Soling quest
            newWorld.AddLocation(3, -1, "Mist of Clouds", "This area is corrupting time by time.", "Forest.jpg");
            newWorld.AddLocation(3, 0, "Silverbrook", "A beautiful village where you can get strong.", "VIllage2.jpg");
            newWorld.LocationAt(3, 0).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(05));//solin quest


            /** Gromble's Lair **/
            newWorld.AddLocation(3, 1, "Bombing shells", "This place used to be beautiful but now it is corrupted and full of bad monsters.", "DarkForest1.jpg");
            newWorld.LocationAt(3, 1).AddMonster(3, 100);//goblin
            newWorld.LocationAt(3, 1).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(04));//gromble quest
            newWorld.AddLocation(4, 1, "Gromble's Lair", "A place where Gromble's lives in.", "GoblinLair.png");
            newWorld.LocationAt(4, 1).AddMonster(4, 50);//gromble
            newWorld.AddLocation(4, 0, "Bombing shells", "This place used to be beautiful but now it is corrupted.", "DarkForest2.jpg");

            //Solin Shadow
            newWorld.AddLocation(4, -1, "Solin's Palace", "A beautiful town where Solin's rules the place.", "SolinGuard.jpg");
            newWorld.LocationAt(4, -1).AddMonster(6, 75);//solin
            newWorld.AddLocation(5, -1, "Bombing shells", "This place used to be beautiful but now it is corrupted.", "DarkForest3.jpg");

            //Aaron Quest
            newWorld.AddLocation(5, 0, "Diamond Palace", "A beautiful castle that is rich and beautiful.", "Castle2.jpg");
            newWorld.LocationAt(5, 0).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(06));//aaron quest
            newWorld.LocationAt(5, 0).TraderHere = TraderFactory.GetTraderByName("Susan");
            newWorld.AddLocation(6, 0, "Bombing shells", "This place used to be beautiful but now it is corrupted.", "DarkForest4.jpg");
            newWorld.AddLocation(6, -1, "Bombing shells", "This place used to be beautiful but now it is corrupted.", "DarkForest5.jpg");
            
            //Aaron Palace
            newWorld.AddLocation(6, 1, "King Auron's Throne", "A Throne that only powerful living creatures could sit.", "AuronThrone.jpg");
            newWorld.LocationAt(6, 1).AddMonster(7, 100);//Aaron

            return newWorld;
        }
    }
}
