using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using StyxEngine.Engine;
using StyxEngine.Utils;

namespace StyxEngine.Levels.TestLevel
{
    public partial class TestLevel2: UserControl
    {
        public List<PictureBox> Obstacles { get; private set; } = new List<PictureBox>();

        private GameState gameState;
        public TestLevel2(GameState state)
        {
            InitializeComponent();
            this.gameState = state;

            LevelInitializer.InitializeLevel(this, gameState, out List<PictureBox> collectedObstacles);
            Obstacles = collectedObstacles;
        }
    }
}
