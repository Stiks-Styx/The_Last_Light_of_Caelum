using System.Windows.Forms;

namespace StyxEngine.Components
{
    public class HealthBar
    {
        private MainGame _mainGame;
        private ProgressBar _healthProgressBar;

        public int MaxHealth { get; private set; } = 100;

        public HealthBar(MainGame mainGame, ProgressBar healthProgressBar, int maxHealth = 100)
        {
            _mainGame = mainGame;
            _healthProgressBar = healthProgressBar;
            MaxHealth = maxHealth;

            _healthProgressBar.Minimum = 0;
            _healthProgressBar.Maximum = maxHealth;
            _healthProgressBar.Value = maxHealth;
        }

        // Call this when player health changes
        public void SetHealth(int currentHealth, int maxHealth)
        {
            if (currentHealth < 0) currentHealth = 0;
            if (currentHealth > maxHealth) currentHealth = maxHealth;

            _healthProgressBar.Maximum = maxHealth;
            _healthProgressBar.Value = currentHealth;
        }
    }
}
