using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StyxEngine.UIElements.Decoration.Destroyable
{
    public class Barrel1 : PictureBox
    {
        public Barrel1()
        {
            this.BackColor = Color.Transparent;
            this.Enabled = false;
            this.Size = new Size(32, 34);
            this.Tag = "Destroyable";
            this.BackgroundImage = Properties.DestroyableResources.barrel;
            this.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.Controls.Add(this);
        }
    }
}
