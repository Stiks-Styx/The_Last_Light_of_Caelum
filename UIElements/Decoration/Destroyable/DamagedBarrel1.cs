using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StyxEngine.UIElements.Decoration.Destroyable
{
    public class DamagedBarrel1 : Barrel1
    {
        public DamagedBarrel1()
        {
            this.Size = new Size(32, 26);
            this.BackgroundImage = Properties.DestroyableResources.barrel_damaged;
            this.Tag = null;
        }
    }
}
