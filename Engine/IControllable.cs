using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StyxEngine.Engine
{
    public interface IControllable
    {
        void KeyDown(Keys key);
        void KeyUp(Keys key);
    }
}
