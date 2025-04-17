using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StyxEngine.Utils;

namespace StyxEngine.UIElements
{
    public class Collectible : PictureBox
    {
        public Collectible()
        {
            this.Tag = CollisionType.Collectible.ToString();
            this.Size = new Size(50, 50);
            this.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        }
    }
}
