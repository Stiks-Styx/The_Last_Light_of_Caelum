using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StyxEngine.Utils
{
    public static class ObstacleControlsHelper
    {
        public static List<PictureBox> CollectObstacles(Control container)
        {
            var obstacles = new List<PictureBox>();

            foreach (Control control in container.Controls)
            {
                if (control is PictureBox pb)
                {
                    if (control.Tag == "Wall" ||
                        control.Tag == "Enemy" ||
                        control.Tag == "Hazard" ||
                        control.Tag == "Collectible" ||
                        control.Tag == "Goal")
                    {
                        obstacles.Add(pb);
                    }
                }
            }

            return obstacles;
        }

        public static List<PictureBox> CollectWalls(Control container)
        {
            var walls = new List<PictureBox>();

            foreach (Control control in container.Controls)
            {
                if (control is PictureBox pb && pb.Tag is CollisionType.Wall)
                {
                    walls.Add(pb);
                }
            }

            return walls;
        }
    }
}
