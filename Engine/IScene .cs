using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StyxEngine.Engine
{
    public interface IScene
    {
        void Update();
        void Draw(Graphics g);
    }
}
