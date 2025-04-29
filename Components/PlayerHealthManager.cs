namespace StyxEngine.Components
{
    public class PlayerHealthManager
    {
        private int currentHealth;
        private int maxHealth;

        private HealthBar healthBar;

        public PlayerHealthManager(HealthBar healthBar, int startingHealth = 100)
        {
            this.healthBar = healthBar;
            maxHealth = startingHealth;
            currentHealth = startingHealth;

            UpdateUI();
        }

        public void TakeDamage(int amount)
        {
            currentHealth = Math.Max(0, currentHealth - amount);
            UpdateUI();
        }

        public void Heal(int amount)
        {
            currentHealth = Math.Min(maxHealth, currentHealth + amount);
            UpdateUI();
        }

        public void SetHealth(int value)
        {
            currentHealth = Math.Clamp(value, 0, maxHealth);
            UpdateUI();
        }

        public int GetHealth() => currentHealth;

        private void UpdateUI()
        {
            healthBar.SetHealth(currentHealth, maxHealth);
        }
    }
}
