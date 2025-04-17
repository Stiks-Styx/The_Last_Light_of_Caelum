using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StyxEngine.UIElements.Tiles
{
    public class Tiles : Wall
    {
        private static readonly Random random = new Random();
        public Tiles()
        {
            int index = random.Next(0, 2);
            Image = index == 0 ? Properties.TilesResources.floor_tile_2 : Properties.TilesResources.floor_tile_3;
        }
    }
}
