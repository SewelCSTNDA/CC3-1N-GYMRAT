using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.ViewModels
{
    public class GameSession
    {
        Player CurrentPlayer { get; set; }
        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Nymph";
            CurrentPlayer.CharacterClass = "Dryad";
            CurrentPlayer.HitPoints = 10;
            CurrentPlayer.Gold = 10;
            CurrentPlayer.ExperiencePoints = 10;
            CurrentPlayer.Level = 1;
        }
    }
}
