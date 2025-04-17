using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StyxEngine.Engine
{
    public static class SceneManager
    {
        public static void ChangeScene(Form form, UserControl newScene)
        {
            form.Controls.Clear();
            newScene.Dock = DockStyle.Fill;
            form.Controls.Add(newScene);
            newScene.Focus();
        }

        public static void RegisterObstacles(MainGame game, UserControl level)
        {
            if (level is ILevelWithObstacles levelWithObstacles)
            {
                game.Obstacles.AddRange(levelWithObstacles.Obstacles);
            }
        }
    }
}
