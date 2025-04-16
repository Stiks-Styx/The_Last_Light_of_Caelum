using System.Windows.Forms;
using StyxEngine.Engine;
using Timer = System.Windows.Forms.Timer;
using StyxEngine.Scenes;
using StyxEngine.Utils;

namespace StyxEngine
{
    public partial class MenuForm : Form
    {

        private Timer gameTimer;

        public MenuForm()
        {
            InitializeComponent();
            SceneManager.SetScene(new Menu());

            // Initialize Timer for game loop
            gameTimer = new Timer();
            gameTimer.Interval = 16; // ~60 FPS
            gameTimer.Tick += GameLoop;
            gameTimer.Start();

            this.KeyDown += (s, e) => InputManager.KeyDown(e.KeyCode);
            this.KeyUp += (s, e) => InputManager.KeyUp(e.KeyCode);

/*
            this.MouseDown += (s, e) => InputManager.MouseDown(e.Button);
            this.MouseUp += (s, e) => InputManager.MouseUp(e.Button);
            this.MouseMove += (s, e) => InputManager.MouseMove(e.X, e.Y);*/
        }

        private void GameLoop(object sender, EventArgs e)
        {
            SceneManager.Update(); // We'll implement this
            Invalidate();          // Triggers OnPaint
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            SceneManager.Draw(e.Graphics); // We'll implement this
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;

            this.Size = new Size(Convert.ToInt32(0.5 * workingRectangle.Width), Convert.ToInt32(0.5 * workingRectangle.Height));

        }
    }
}
