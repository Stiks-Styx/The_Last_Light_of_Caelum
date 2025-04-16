using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using StyxEngine.Engine;
using StyxEngine.Utils;
using Timer = System.Windows.Forms.Timer;

namespace StyxEngine.Engine
{
    public class GameLoop
    {
        private Timer gameTimer;
        private Stopwatch stopwatch;
        private long lastTickTime;

        private MainGame _mainGame;
        private PlayerControls playerControls;
        private DebugInfoManager debug;
        private int currentHealth = 100;
        private List<GameObject> gameObjects = new List<GameObject>();

        public GameLoop(MainGame mainGame, PlayerControls playerControls, DebugInfoManager debug)
        {
            _mainGame = mainGame;
            this.playerControls = playerControls;
            this.debug = debug;

            stopwatch = new Stopwatch();
            gameTimer = new Timer();
            gameTimer.Interval = 16; // ~60 FPS
            gameTimer.Tick += GameTick;
        }

        public void Start()
        {
            stopwatch.Start();
            lastTickTime = stopwatch.ElapsedMilliseconds;
            gameTimer.Start();
        }

        private void GameTick(object sender, EventArgs e)
        {
            long now = stopwatch.ElapsedMilliseconds;
            float deltaTime = (now - lastTickTime) / 1000f;
            lastTickTime = now;

            foreach (var obj in gameObjects)
                obj.Update();

            playerControls.UpdatePlayerMovement(deltaTime);
            debug.DebugInfoUpdate(currentHealth);

            InputManager.Update(); // optional: use if you're tracking pressed vs held keys
        }
    }
}
