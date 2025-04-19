using System.Windows.Forms;
using StyxEngine.Components;
using StyxEngine.Utils;

namespace StyxEngine.Engine
{
    public class GameState
    {
        public PictureBox Player { get; set; }
        public PictureBox PlayerHitBox { get; set; }
        public PictureBox RightAttackHitBox { get; set; }
        public PictureBox LeftAttackHitBox { get; set; }
        public ProgressBar HealthBar { get; set; }
        public ProgressBar DashCooldownBar { get; set; }

        public PlayerControls PlayerControls { get; set; }
        public DebugInfoManager DebugInfoManager { get; set; }

        // ToDO: Add any shared global objects
        //-->Shared Objects<--//
        public int CurrentHealth { get; set; }
        public int LivesAmount { get; set; }
        public int DashCooldown { get; set; }
        public int Score { get; set; }
        //-->Shared Objects<--//

        // ToDO: Scene-level state flags
        public string CurrentLevelName { get; set; }
        public bool IsPaused { get; set; } = false;

        public GameState()
        {
            // Add initialization defaults here if needed
        }
    }
}
