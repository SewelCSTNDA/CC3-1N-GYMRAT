using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Engine.Models
{
    public class World
    {
        private List<Location> _locations = new List<Location>();
        internal void AddLocation(int xCoordinate, int yCoordinate,
                                  string name, string description, string imageName)
        {
            _locations.Add(new Location(xCoordinate, yCoordinate, name, description,
                                        $"/Engine;component/Images/Locations/{imageName}"));
        }

        public Location LocationAt(int x, int y)
        {
            foreach(Location loc in _locations)
            {
                if(loc.XCoordinate == x && loc.YCoordinate == y)
                {
                    return loc;
                }
            }
            return null;
        }

    }
}
