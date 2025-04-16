using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StyxEngine.Engine
{
    public static class SceneManager
    {
        private static IScene currentScene;

        public static void SetScene(IScene newScene)
        {
            currentScene = newScene;
        }

        public static void Update()
        {
            currentScene?.Update();
        }

        public static void Draw(Graphics g)
        {
            currentScene?.Draw(g);
        }
    }
}
