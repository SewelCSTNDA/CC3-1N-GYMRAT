using Engine.Factories;
using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }
        public World CurrentWorld { get; set; }
        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Nymph";
            CurrentPlayer.CharacterClass = "Dryad";
            CurrentPlayer.HitPoints = 10;
            CurrentPlayer.Gold = 10;
            CurrentPlayer.ExperiencePoints = 10;
            CurrentPlayer.Level = 1;

            WorldFactory worldFactory = new WorldFactory();
            CurrentWorld = worldFactory.CreateWorld();

            CurrentLocation = CurrentWorld.LocationAt(0, 0);
        }
    }
}
