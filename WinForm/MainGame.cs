using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StyxEngine.Components;
using StyxEngine.Engine;
using StyxEngine.Levels.TestLevel;
using StyxEngine.Utils;

namespace StyxEngine
{
    public partial class MainGame : Form
    {
        private GameLoop gameLoop;
        private HealthBar healthBar;
        public bool isDebugging = true;
        public readonly int speed = 5;
        public List<PictureBox> Obstacles { get; set; } = new List<PictureBox>();

        private PlayerControls playerControls;  // Declare PlayerControls
        private DebugInfoManager debugInfoManager;  // Declare DebugInfoManager
        public MainGame()
        {
            InitializeComponent();

            this.Controls.Add(rightAttackHitBox);
            this.Controls.Add(leftAttackHitBox);

            // Create instances of PlayerControls and DebugInfoManager
            playerControls = new PlayerControls(this, healthBar, rightAttackHitBox, leftAttackHitBox);
            debugInfoManager = new DebugInfoManager(this);

            // Pass all required arguments to the GameLoop constructor
            gameLoop = new GameLoop(this, playerControls, debugInfoManager);
            gameLoop.Start();

            healthBar = new HealthBar(this);

            Player.Tag = "Player";
            playerHitBox.Location = Player.Location;

            Controls.Add(Player);

            // Hook up input events
            // Keyboard events and Mouse events
            this.KeyDown += (s, e) => InputManager.KeyDown(e.KeyCode);
            this.KeyUp += (s, e) => InputManager.KeyUp(e.KeyCode);
            this.MouseDown += (s, e) => InputManager.MouseDown(e.Button);
            this.MouseUp += (s, e) => InputManager.MouseUp(e.Button);

            TestLevel1 level1 = new TestLevel1(GetGameState());
            //TestLevel2 level2 = new TestLevel2(GetGameState());
            SceneManager.RegisterObstacles(this, level1);
            SceneManager.ChangeScene(this, level1);
        }

        private void MainGame_KeyDown(object sender, KeyEventArgs e)
        {
            InputManager.KeyDown(e.KeyCode);
        }

        private void MainGame_KeyUp(object sender, KeyEventArgs e)
        {
            InputManager.KeyUp(e.KeyCode);
        }

        private GameState GetGameState()
        {
            GameState gameState = new GameState
            {
                Player = this.Player,
                PlayerHitBox = this.playerHitBox,
                RightAttackHitBox = this.rightAttackHitBox,
                LeftAttackHitBox = this.leftAttackHitBox,
                HealthBar = this.playerHealthBar,
                DashCooldownBar = this.DashCooldownBar,
                PlayerControls = this.playerControls,
                DebugInfoManager = this.debugInfoManager,
                CurrentHealth = this.playerHealthBar.Value,
                LivesAmount = 3
            };
            return gameState;
        }
    }
}
