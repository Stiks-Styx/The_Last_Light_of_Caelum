using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StyxEngine.Utils;

namespace StyxEngine.UIElements
{
    public class GoalVertical : PictureBox
    {
        public GoalVertical()
        {
            this.Tag = CollisionType.Goal.ToString();
            this.Anchor = AnchorStyles.Bottom | AnchorStyles.Top;
            this.BackColor = Color.Transparent;
            this.Margin = new Padding(0, 0, 0, 0);
        }
    }
}
