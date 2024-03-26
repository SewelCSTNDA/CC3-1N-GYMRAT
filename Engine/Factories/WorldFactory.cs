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
        public static World CreateWorld()
        {
            World newWorld = new World();

            /** Oracle's Refuge **/
            newWorld.AddLocation(0, 0, "Oracle's Refuge", "This is the place where you will be guided by a spirit.", "OracleCastle.jpg");

            /** Slime Field**/
            newWorld.AddLocation(1, 0, "Slime Field", "This area full of harmful slimes.", "GrassField1.jpg");
            newWorld.LocationAt(1, 0).AddMonster(1, 100);

            newWorld.AddLocation(1, -1, "Village of Whispering Pines", "This place is full of villagers where you can get cool items.", "Village1.jpg");
            newWorld.LocationAt(1, -1).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(1));
            newWorld.AddLocation(1, -2, "Cryztalize Mineshaft", "This area is full of crystals and crystalized enemy", "CrystalMS.jpg");
            newWorld.AddLocation(2, -1, "Grassfield", "This place is filled with human size grasses.", "GrassField2.jpg");
            newWorld.AddLocation(2, 0, "Vexen's Raid", "This place is where Vexen's starting his move to raid the castle.", "VexenRaid.jpg");
            newWorld.AddLocation(2, 1, "Castle of Misty Gold", "This place is a trader's area where you can buy and sell stuff and many more.", "Castle1.jpg");
            newWorld.AddLocation(1, 1, "????", "????", "EasterEgg.png");
            newWorld.AddLocation(3, -1, "Mist of Clouds", "This area is corrupting time by time.", "Forest.jpg");
            newWorld.AddLocation(3, 0, "Silverbrook", "A beautiful village where you can get strong.", "VIllage2.jpg");
            newWorld.AddLocation(3, 1, "Bombing shells", "This place used to be beautiful but now it is corrupted.", "DarkForest1.jpg");

            /** Gromble's Lair **/
            newWorld.AddLocation(4, 1, "Gromble's Lair", "A place where Gromble's lives in.", "GoblinLair.png");
            newWorld.LocationAt(4, 1).AddMonster(3, 100);

            newWorld.AddLocation(4, 0, "Bombing shells", "This place used to be beautiful but now it is corrupted.", "DarkForest2.jpg");
            newWorld.AddLocation(4, -1, "Solin's Palace", "A beautiful town where Solin's rules the place.", "SolinGuard.jpg");
            newWorld.AddLocation(5, -1, "Bombing shells", "This place used to be beautiful but now it is corrupted.", "DarkForest3.jpg");
            newWorld.AddLocation(5, 0, "Diamond Palace", "A beautiful castle that is rich and beautiful.", "Castle2.jpg");
            newWorld.AddLocation(6, 0, "Bombing shells", "This place used to be beautiful but now it is corrupted.", "DarkForest4.jpg");
            newWorld.AddLocation(6, -1, "Bombing shells", "This place used to be beautiful but now it is corrupted.", "DarkForest5.jpg");
            newWorld.AddLocation(6, 1, "King Auron's Throne", "A Throne that only powerful living creatures could sit.", "AuronThrone.jpg");
            return newWorld;
        }
    }
}
