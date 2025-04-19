using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace StyxEngine.Utils
{
    public static class CollisionManager
    {
        /// <summary>
        /// Checks if two PictureBoxes are colliding.
        /// </summary>
        public static bool IsColliding(PictureBox obj1, PictureBox obj2)
        {
            return obj1.Bounds.IntersectsWith(obj2.Bounds);
        }

        /// <summary>
        /// Checks if a PictureBox is colliding with any in a list and returns the type of collision.
        /// </summary>
        public static CollisionType CheckCollisionType(PictureBox obj, List<PictureBox> obstacles)
        {
            foreach (var obstacle in obstacles)
            {
                if (obj.Bounds.IntersectsWith(obstacle.Bounds))
                {
                    if (obstacle.Tag != null && Enum.TryParse(obstacle.Tag.ToString(), out CollisionType collisionType))
                    {
                        return collisionType;
                    }
                }
            }
            return CollisionType.None; // No collision
        }

        public static CollisionType CheckCollisionType(Rectangle rect, List<PictureBox> obstacles)
        {
            foreach (var obstacle in obstacles)
            {
                if (rect.IntersectsWith(obstacle.Bounds))
                {
                    if (obstacle.Tag != null && Enum.TryParse(obstacle.Tag.ToString(), out CollisionType collisionType))
                    {
                        return collisionType;
                    }
                }
            }
            return CollisionType.None;
        }
    }
}
