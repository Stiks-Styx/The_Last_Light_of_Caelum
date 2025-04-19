using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StyxEngine.Utils;

namespace StyxEngine.UIElements
{
    public class GoalHorizontal : PictureBox
    {
        public GoalHorizontal()
        {
            this.Tag = CollisionType.Goal.ToString();
            this.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            this.BackColor = Color.Transparent;
            this.Margin = new Padding(0, 0, 0, 0);
        }
    }
}
