using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StyxEngine.Utils;

namespace StyxEngine.UIElements
{
    public class Wall : PictureBox
    {
        public Wall()
        {
            this.Tag = CollisionType.Wall.ToString();
            this.Size = new Size(64, 64);
            this.Margin = new Padding(0,0,0,0);
            this.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.BackColor = Color.Black;
            this.Enabled = false;
            this.BackgroundImageLayout = ImageLayout.Tile;
        }
    }
}
