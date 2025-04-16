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
using StyxEngine.Utils;

namespace StyxEngine
{
    public partial class MainGame : Form
    {
        private GameLoop gameLoop;
        private HealthBar healthBar;
        public bool isDebugging = true;
        public readonly int speed = 5;
        public List<PictureBox> Obstacles { get; private set; } = new List<PictureBox>();

        private PlayerControls playerControls;  // Declare PlayerControls
        private DebugInfoManager debugInfoManager;  // Declare DebugInfoManager

        public MainGame()
        {
            InitializeComponent();

            // In your MainGame constructor or initialization method:
            PictureBox rightAttackHitBox = new PictureBox();
            PictureBox leftAttackHitBox = new PictureBox();

            // Optionally configure these hitboxes (size, background color, etc.) and add them to Controls.
            rightAttackHitBox.Size = new Size(50, 30);
            leftAttackHitBox.Size = new Size(50, 30);
            rightAttackHitBox.Enabled = false;
            leftAttackHitBox.Enabled = false;
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

            wall1.Tag = CollisionType.Wall;
            wall2.Tag = CollisionType.Wall;
            wall3.Tag = CollisionType.Wall;
            wall4.Tag = CollisionType.Wall;
            wall5.Tag = CollisionType.Wall;
            wall6.Tag = CollisionType.Wall;
            wall7.Tag = CollisionType.Wall;
            wall8.Tag = CollisionType.Wall;
            wall9.Tag = CollisionType.Wall;
            wall10.Tag = CollisionType.Wall;
            wall11.Tag = CollisionType.Wall;
            wall12.Tag = CollisionType.Wall;
            wall13.Tag = CollisionType.Wall;
            enemy.Tag = CollisionType.Enemy;
            item1.Tag = CollisionType.Collectible;

            Obstacles.Add(wall1);
            Obstacles.Add(wall2);
            Obstacles.Add(wall3);
            Obstacles.Add(wall4);
            Obstacles.Add(wall5);
            Obstacles.Add(wall6);
            Obstacles.Add(wall7);
            Obstacles.Add(wall8);
            Obstacles.Add(wall9);
            Obstacles.Add(wall10);
            Obstacles.Add(wall11);
            Obstacles.Add(wall12);
            Obstacles.Add(wall13);
            Obstacles.Add(enemy);
            Obstacles.Add(item1);

            // Hook up input events
            // Keyboard events
            this.KeyDown += (s, e) => InputManager.KeyDown(e.KeyCode);
            this.KeyUp += (s, e) => InputManager.KeyUp(e.KeyCode);

            // Mouse events
            this.MouseDown += (s, e) => InputManager.MouseDown(e.Button);
            this.MouseUp += (s, e) => InputManager.MouseUp(e.Button);

            Player.Parent = this;
            Player.Focus();
            this.Focus();
        }

        private void MainGame_KeyDown(object sender, KeyEventArgs e)
        {
            InputManager.KeyDown(e.KeyCode);
        }

        private void MainGame_KeyUp(object sender, KeyEventArgs e)
        {
            InputManager.KeyUp(e.KeyCode);
        }

        // Kinda not working
        private void AnyButton_Click(object sender, EventArgs e)
        {
            InputManager.ResetKeys();
            this.ActiveControl = null; // Remove focus from button

            Task.Delay(1).ContinueWith(_ =>
            {
                this.Invoke((MethodInvoker)(() => this.Focus()));
            });
        }
    }

}
