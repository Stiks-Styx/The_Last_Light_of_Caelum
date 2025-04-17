using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StyxEngine.Engine;
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

            this.KeyDown += (s, e) => InputManager.KeyDown(e.KeyCode);
            this.KeyUp += (s, e) => InputManager.KeyUp(e.KeyCode);
            this.MouseDown += (s, e) => InputManager.MouseDown(e.Button);
            this.MouseUp += (s, e) => InputManager.MouseUp(e.Button);

            this.gameState = state;

            // Example: add player to the level
            this.Controls.Add(gameState.Player);
            this.Controls.Add(gameState.PlayerHitBox);
            this.Controls.Add(gameState.HealthBar);
            this.Controls.Add(gameState.RightAttackHitBox);
            this.Controls.Add(gameState.LeftAttackHitBox);

            gameState.Player.Parent = this;
            gameState.PlayerHitBox.Parent = this;
            gameState.Player.Visible = true;
            gameState.PlayerHitBox.Visible = true;
            gameState.PlayerHitBox.BringToFront();

            gameState.RightAttackHitBox.BringToFront();
            gameState.LeftAttackHitBox.BringToFront();

            // You may need to reposition elements
            gameState.Player.Location = new Point(100, 100);
            gameState.PlayerHitBox.Location = gameState.Player.Location;

            Obstacles = ObstacleControlsHelper.CollectObstacles(this);
            var walls = ObstacleControlsHelper.CollectWalls(this);
            foreach (var wall in walls)
            {
                this.Controls.Add(wall); // Only needed if they weren’t added already
            }
        }
    }

}
