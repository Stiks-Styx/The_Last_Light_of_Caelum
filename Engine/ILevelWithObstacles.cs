using System.Collections.Generic;
using System.Windows.Forms;

namespace StyxEngine.Engine
{
    public interface ILevelWithObstacles
    {
        List<PictureBox> Obstacles { get; }
    }
}
