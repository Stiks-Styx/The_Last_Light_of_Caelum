using StyxEngine.Engine;

namespace StyxEngine.Utils
{
    public static class LevelInitializer
    {
        public static void InitializeLevel(UserControl levelControl, GameState state, out List<PictureBox> obstacles)
        {
            levelControl.Dock = DockStyle.Fill; // Ensure level fills parent

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
            state.PlayerHitBox.Parent = levelControl;
            state.Player.Visible = true;

            // Determine spawn position
            var spawnPos = state.OverrideSpawnPosition ?? new Point(
                levelControl.Width / 2 - state.Player.Width / 2,
                levelControl.Height / 2 - state.Player.Height / 2
            );
            Console.WriteLine($"Initializing level with spawn position: {spawnPos}");

            state.Player.Location = spawnPos;
            state.PlayerHitBox.Location = spawnPos;

            // Bring player-related hitboxes to front
            /*            state.Player.BringToFront();
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
