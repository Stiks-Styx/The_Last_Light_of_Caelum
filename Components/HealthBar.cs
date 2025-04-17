using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StyxEngine.Components
{
    public class HealthBar
    {
        public int maxHealth = 100;
        private MainGame _mainGame;

        public HealthBar(MainGame mainGame)
        {
            _mainGame = mainGame;
        }

        // Update the health bar value
        public void UpdateHealth(int newHealth)
        {
            if (newHealth <= 0) newHealth = 0;
            if (newHealth >= maxHealth) newHealth = maxHealth;
        }
    }
}
