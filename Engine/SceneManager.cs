using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
                game.Obstacles.Clear();
                game.Obstacles.AddRange(levelWithObstacles.Obstacles);
            }
        }

        public static UserControl LoadLevelByName(string levelName, GameState state)
        {
            return levelName switch
            {
                "TestLevel1" => new Levels.TestLevel.TestLevel1(state),
                "TestLevel2" => new Levels.TestLevel.TestLevel2(state),
                _ => throw new ArgumentException("Unknown level name")
            };
        }
    }
}
