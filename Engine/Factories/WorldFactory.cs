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
        public World CreateWorld()
        {
            World newWorld = new World();
            newWorld.AddLocation(0, 0, "Oracle's Refuge", "This is the place where you will be guided by a spirit.", "/Engine;component/Images/Locations/OracleCastle.jpg");
            newWorld.AddLocation(1, 0, "Slime Field", "This area full of harmful slimes.", "/Engine;component/Images/Locations/GrassField1.jpg");
            newWorld.AddLocation(1, -1, "Village of Whispering Pines", "This place is full of villagers where you can get cool items.", "/Engine;component/Images/Locations/Village1.jpg");
            newWorld.AddLocation(1, -2, "Cryztalize Mineshaft", "This area is full of crystals and crystalized enemy", "/Engine;component/Images/Locations/CrystalMS.jpg");
            newWorld.AddLocation(2, -1, "Grassfield", "This place is filled with human size grasses.", "/Engine;component/Images/Locations/GrassField2.jpg");
            newWorld.AddLocation(2, 0, "Vexen's Raid", "This place is where Vexen's starting his move to raid the castle.", "/Engine;component/Images/Locations/VexenRaid.jpg");
            newWorld.AddLocation(2, 1, "Castle of Misty Gold", "This place is a trader's area where you can buy and sell stuff and many more.", "/Engine;component/Images/Locations/Castle1.jpg");
            newWorld.AddLocation(1, 1, "????", "????", "/Engine;component/Images/Locations/EasterEgg.png");
            newWorld.AddLocation(3, -1, "Mist of Clouds", "This area is corrupting time by time.", "/Engine;component/Images/Locations/Forest.jpg");
            newWorld.AddLocation(3, 0, "Silverbrook", "A beautiful village where you can get strong.", "/Engine;component/Images/Locations/VIllage2.jpg");
            newWorld.AddLocation(3, 1, "Bombing shells", "This place used to be beautiful but now it is corrupted.", "/Engine;component/Images/Locations/DarkForest1.jpg");
            newWorld.AddLocation(4, 1, "Gromble's Lair", "A place where Gromble's lives in.", "/Engine;component/Images/Locations/GoblinLair.png");
            newWorld.AddLocation(4, 0, "Bombing shells", "This place used to be beautiful but now it is corrupted.", "/Engine;component/Images/Locations/DarkForest2.jpg");
            newWorld.AddLocation(4, -1, "Solin's Palace", "A beautiful town where Solin's rules the place.", "/Engine;component/Images/Locations/SolinGuard.jpg");
            newWorld.AddLocation(5, -1, "Bombing shells", "This place used to be beautiful but now it is corrupted.", "/Engine;component/Images/Locations/DarkForest3.jpg");
            newWorld.AddLocation(5, 0, "Diamond Palace", "A beautiful castle that is rich and beautiful.", "/Engine;component/Images/Locations/Castle2.jpg");
            newWorld.AddLocation(6, 0, "Bombing shells", "This place used to be beautiful but now it is corrupted.", "/Engine;component/Images/Locations/DarkForest4.jpg");
            newWorld.AddLocation(6, -1, "Bombing shells", "This place used to be beautiful but now it is corrupted.", "/Engine;component/Images/Locations/DarkForest5.jpg");
            newWorld.AddLocation(6, 1, "King Auron's Throne", "A Throne that only powerful living creatures could sit.", "/Engine;component/Images/Locations/AuronThrone.jpg");
            return newWorld;
        }
    }
}
