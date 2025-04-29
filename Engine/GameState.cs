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

        public int CurrentHealth { get; set; }
        public int LivesAmount { get; set; }
        public int DashCooldown { get; set; }
        public int Score { get; set; }
        public Point? OverrideSpawnPosition { get; set; } = null;

        public  string CurrentLevelName { get; set; }
        public bool IsPaused { get; set; } = false;

        public string LastLevelName { get; set; }
        public Point LastExitSpawnPosition { get; set; }
    }
}
