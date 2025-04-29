using StyxEngine.Components;
using StyxEngine.Engine;
using StyxEngine.Utils;

namespace StyxEngine
{
    public partial class MainGame : Form
    {
        private GameLoop gameLoop;
        private PlayerControls playerControls;
        private DebugInfoManager debugInfoManager;
        private HealthBar healthBar;
        private PlayerHealthManager healthManager;
        private GameState gameState;
        public GameState GameState
        {
            get => gameState;
            private set => gameState = value;
        }

        public bool isDebugging = true;
        public readonly int speed = 5;
        public List<PictureBox> Obstacles { get; set; } = new List<PictureBox>();

        public MainGame()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            // Add attack hitboxes to controls
            Controls.Add(rightAttackHitBox);
            Controls.Add(leftAttackHitBox);

            // Initialize UI and game-related components
            gameState = GetGameState();
            healthBar = new HealthBar(this, playerHealthBar);
            healthManager = new PlayerHealthManager(healthBar);
            debugInfoManager = new DebugInfoManager(this);
            playerControls = new PlayerControls(this, healthBar, rightAttackHitBox, leftAttackHitBox);

            // Initialize Game Loop
            gameLoop = new GameLoop(this, playerControls, debugInfoManager);
            gameLoop.Start();

            // Set up Player and Hitbox
            Player.Tag = "Player";
            playerHitBox.Location = Player.Location;
            Controls.Add(Player);

            // Set up input event hooks
            HookInputEvents();

            // Load test level
            LoadInitialScene();
        }

        private void HookInputEvents()
        {
            this.KeyDown += (s, e) => InputManager.KeyDown(e.KeyCode);
            this.KeyUp += (s, e) => InputManager.KeyUp(e.KeyCode);
            this.MouseDown += (s, e) => InputManager.MouseDown(e.Button);
            this.MouseUp += (s, e) => InputManager.MouseUp(e.Button);
        }

        private GameState GetGameState()
        {
            gameState = new GameState
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

        private void LoadInitialScene()
        {
            gameState.CurrentLevelName = "TestLevel1";
            var level = SceneManager.LoadLevelByName("TestLevel1", gameState);
            SceneManager.RegisterObstacles(this, level);
            SceneManager.ChangeScene(this, level);

            gameState.PlayerHitBox.Location = new Point(100, 300); // initial spawn
            gameState.Player.Location = gameState.PlayerHitBox.Location;
        }

        public void TransitionToLevel(string levelName, Point spawnPos)
        {
            Console.WriteLine($"[Transition] Switching to {levelName} at {spawnPos}");

            // Update game state
            gameState.LastLevelName = gameState.CurrentLevelName;
            gameState.LastExitSpawnPosition = spawnPos;
            gameState.CurrentLevelName = levelName;
            gameState.OverrideSpawnPosition = spawnPos;

            // Load and initialize new level
            var newLevel = SceneManager.LoadLevelByName(levelName, gameState);
            SceneManager.RegisterObstacles(this, newLevel);
            SceneManager.ChangeScene(this, newLevel);

            // Reset override position
            gameState.OverrideSpawnPosition = null;

            // Ensure player position updates
            gameState.PlayerHitBox.Location = spawnPos;
            gameState.Player.Location = spawnPos;
        }
        public void SafeTransition(string levelName, Point spawnPos)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => SafeTransition(levelName, spawnPos)));
                return;
            }

            Console.WriteLine($"--- START TRANSITION TO {levelName} ---");
            Console.WriteLine($"Current Level: {GameState.CurrentLevelName}");

            // Update game state
            GameState.LastLevelName = GameState.CurrentLevelName;
            GameState.CurrentLevelName = levelName;
            GameState.OverrideSpawnPosition = spawnPos;

            // Load new level
            var newLevel = SceneManager.LoadLevelByName(levelName, GameState);
            newLevel.Size = this.ClientSize;
            newLevel.Dock = DockStyle.Fill;

            // Clear previous level
            Controls.Clear();
            Controls.Add(newLevel);
            newLevel.Focus();

            // Force position update
            GameState.PlayerHitBox.Location = spawnPos;
            GameState.Player.Location = spawnPos;

            Console.WriteLine($"New Player Position: {GameState.Player.Location}");
            Console.WriteLine($"--- TRANSITION COMPLETE ---");
        }
    }
}
