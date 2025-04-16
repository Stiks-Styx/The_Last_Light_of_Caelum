using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StyxEngine.Engine
{
    public abstract class GameObject
    {
        public PointF Position { get; set; }
        public abstract void Update();
        public abstract void Draw(Graphics g);
    }
}
