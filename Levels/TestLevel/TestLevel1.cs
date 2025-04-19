﻿using StyxEngine.Engine;
using StyxEngine.Utils;

namespace StyxEngine.Levels.TestLevel
{
    public partial class TestLevel1 : UserControl, ILevelWithObstacles
    {
        public List<PictureBox> Obstacles { get; private set; } = new List<PictureBox>();

        private GameState gameState;

        public TestLevel1(GameState state)
        {
            InitializeComponent();
            this.gameState = state;

            LevelInitializer.InitializeLevel(this, gameState, out List<PictureBox> collectedObstacles);
            Obstacles = collectedObstacles;
        }
    }
}
