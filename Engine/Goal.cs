using System.Drawing;
using System.Windows.Forms;
using StyxEngine.Utils;

namespace StyxEngine.Engine
{
    public class Goal : PictureBox
    {
        public string TargetLevelName { get; }
        public Point TargetSpawnPosition { get; }

        public Goal(string targetLevelName, Point targetSpawnPosition)
        {
            this.TargetLevelName = targetLevelName;
            this.TargetSpawnPosition = targetSpawnPosition;
            this.Size = new Size(50, 50);
            this.BackColor = Color.Gold;
            this.Tag = "Goal";
        }
    }
}
