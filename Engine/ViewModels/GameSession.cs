using Engine.EventArgs;
using Engine.Factories;
using Engine.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Engine.ViewModels
{ 
    public class GameSession : BaseNotificationClass
    {
        public event EventHandler<GameMessageEventArgs> OnMessageRaised;

        #region Properties

        private Location _currentLocation;
        private Monster _currentMonster;
        public World CurrentWorld { get; set; }
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation 
        {
            get { return _currentLocation; }
            set
            {
                _currentLocation = value;

                OnPropertyChanged(nameof(CurrentLocation));
                OnPropertyChanged(nameof(HasLocationToNorth));
                OnPropertyChanged(nameof(HasLocationToEast));
                OnPropertyChanged(nameof(HasLocationToWest));
                OnPropertyChanged(nameof(HasLocationToSouth));

                GivePlayerQuestsAtLocation();
                GetMonsterAtLocation();
            }
        }

        public Monster CurrentMonster
        {
            get { return _currentMonster; }
            set
            {
                _currentMonster = value;

                OnPropertyChanged(nameof(CurrentMonster));
                OnPropertyChanged(nameof(HasMonster));

                if (CurrentMonster != null)
                {
                    RaiseMessage("");
                    RaiseMessage($"You see a {CurrentMonster.Name} here!");
                }
            }
        }

        public Weapon CurrentWeapon {  get; set; }

        public bool HasLocationToNorth
        {
            get
            {
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1) != null;
            }
        }        
        public bool HasLocationToEast
        {
            get
            {
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate) != null;
            }
        }        
        public bool HasLocationToWest
        {
            get
            {
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate) != null;
            }
        }        
        public bool HasLocationToSouth
        {
            get
            {
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1) != null;
            }
        }

        public bool HasMonster => CurrentMonster != null;

        #endregion

        public GameSession()
        {
            CurrentPlayer = new Player
            { 
                Name = "Nymph", 
                CharacterClass = "Dryad", 
                ExperiencePoints = 0, 
                Gold = 0, HitPoints = 20, 
                Level = 1 
            };

            if (!CurrentPlayer.Weapons.Any())
            {
                CurrentPlayer.AddItemToInventory(ItemFactory.CreateGameItem(001));
            }

            CurrentWorld = WorldFactory.CreateWorld();

            CurrentLocation = CurrentWorld.LocationAt(0, 0);

            CurrentPlayer.Inventory.Add(ItemFactory.CreateGameItem(101));
            CurrentPlayer.Inventory.Add(ItemFactory.CreateGameItem(102));
            CurrentPlayer.Inventory.Add(ItemFactory.CreateGameItem(103));
            CurrentPlayer.Inventory.Add(ItemFactory.CreateGameItem(104));
        }



        public void MoveNorth()
        {
            if (HasLocationToNorth)
            {
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1);
            }
        }
        public void MoveEast()
        {
            if (HasLocationToEast)
            {
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate);
            }
        }
        public void MoveWest()
        {
            if (HasLocationToWest)
            {
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate);
            }
        }        
      
        public void MoveSouth()
        {
            if (HasLocationToSouth)
            {
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1);
            }
        }



        private void GivePlayerQuestsAtLocation()
        {
            foreach (Quest quest in CurrentLocation.QuestsAvailableHere)
            {
                if (!CurrentPlayer.Quests.Any(q => q.PlayerQuest.ID == quest.ID))
                {
                    CurrentPlayer.Quests.Add(new QuestStatus(quest));
                }
            }
        }

        private void GetMonsterAtLocation()
        {
            CurrentMonster = CurrentLocation.GetMonster();
        }

        public void AttackCurrentMonster()
        {
            if (CurrentWeapon == null)
            {
                RaiseMessage("You're not holding a weapon!");
                return;
            }

            int damageToMonster = RandomNumberGenerator.NumberBetween(CurrentWeapon.MinimumDamage, CurrentWeapon.MaximumDamage);

            if (damageToMonster == 0)
            {
                RaiseMessage($"You missed the {CurrentMonster}!");
            }
            else
            {
                CurrentMonster.HitPoints -= damageToMonster;
                RaiseMessage($"You hit the {CurrentMonster.Name} for {damageToMonster} damage!");
            }

            if (CurrentMonster.HitPoints <= 0)
            {
                RaiseMessage("");
                RaiseMessage($"You have slain the {CurrentMonster.Name}");

                CurrentPlayer.ExperiencePoints += CurrentMonster.RewardExperiencePoints;
                RaiseMessage($"You have been rewarded with {CurrentMonster.RewardExperiencePoints} experience");

                CurrentPlayer.Gold += CurrentMonster.RewardGold;
                RaiseMessage($"You have been rewarded with {CurrentMonster.RewardGold} Gold");

                foreach(ItemQuantity itemQuantity in CurrentMonster.Inventory)
                {
                    GameItem item = ItemFactory.CreateGameItem(itemQuantity.ItemID);
                    CurrentPlayer.AddItemToInventory(item);
                    RaiseMessage($"You picked up {itemQuantity.Quantity} {item.Name}!");
                }

                GetMonsterAtLocation();
            }
            else
            {
                int damageToPlayer = RandomNumberGenerator.NumberBetween(CurrentMonster.MinimumDamage, CurrentMonster.MaximumDamage);

                if (damageToPlayer == 0)
                {
                    RaiseMessage($"{CurrentMonster.Name} missed!");
                }
                else
                {
                    CurrentPlayer.HitPoints -= damageToPlayer;
                    RaiseMessage($"The {CurrentMonster.Name} hit you for {damageToPlayer} points!");
                }

                if (CurrentPlayer.HitPoints <= 0)
                {
                    RaiseMessage("");
                    RaiseMessage($"{CurrentMonster.Name} killed you!");

                    CurrentLocation = CurrentWorld.LocationAt(0, 0);
                    CurrentPlayer.HitPoints = CurrentPlayer.Level * 10;
                }
            }
        }

        private void RaiseMessage(string message)
        {
            OnMessageRaised?.Invoke(this, new GameMessageEventArgs(message));
        }

    }
}