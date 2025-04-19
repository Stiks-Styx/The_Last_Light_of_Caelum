using StyxEngine.Engine;
using StyxEngine.Utils;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace StyxEngine.Utils
{
    public static class LevelInitializer
    {
        public static void InitializeLevel(UserControl levelControl, GameState state, out List<PictureBox> obstacles)
        {
            // Input bindings
            levelControl.KeyDown += (s, e) => InputManager.KeyDown(e.KeyCode);
            levelControl.KeyUp += (s, e) => InputManager.KeyUp(e.KeyCode);
            levelControl.MouseDown += (s, e) => InputManager.MouseDown(e.Button);
            levelControl.MouseUp += (s, e) => InputManager.MouseUp(e.Button);

            // Add player-related components
            levelControl.Controls.Add(state.Player);
            levelControl.Controls.Add(state.PlayerHitBox);
            levelControl.Controls.Add(state.HealthBar);
            levelControl.Controls.Add(state.DashCooldownBar);
            levelControl.Controls.Add(state.RightAttackHitBox);
            levelControl.Controls.Add(state.LeftAttackHitBox);

            // Set parent and visibility
            state.Player.Parent = levelControl;
            state.Player.Visible = true;
            state.PlayerHitBox.Parent = levelControl;

            // Set starting positions
            state.Player.Location = new Point(100, 100);
            state.PlayerHitBox.Location = state.Player.Location;
/*
            state.PlayerHitBox.Visible = true;
            state.PlayerHitBox.BringToFront();

            state.RightAttackHitBox.BringToFront();
            state.LeftAttackHitBox.BringToFront();*/

            // Collect and optionally add obstacles
            obstacles = ObstacleControlsHelper.CollectObstacles(levelControl);
            var walls = ObstacleControlsHelper.CollectWalls(levelControl);
            foreach (var wall in walls)
            {
                levelControl.Controls.Add(wall);
            }
        }
    }
}
