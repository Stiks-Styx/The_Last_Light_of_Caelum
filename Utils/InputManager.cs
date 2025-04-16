using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StyxEngine.Utils
{
    public static class InputManager
    {
        private static Dictionary<Keys, bool> currentKeys = new();
        private static Dictionary<Keys, bool> previousKeys = new();

        private static bool leftMouseDown = false;
        private static bool leftMousePreviouslyDown = false;

        // --- Keyboard Methods ---

        public static void KeyDown(Keys key) => currentKeys[key] = true;
        public static void KeyUp(Keys key) => currentKeys[key] = false;

        public static bool IsKeyDown(Keys key) =>
            currentKeys.TryGetValue(key, out var down) && down;

        public static bool IsKeyJustPressed(Keys key) =>
            IsKeyDown(key) && (!previousKeys.TryGetValue(key, out var prev) || !prev);

        // --- Mouse Methods ---

        public static void MouseDown(MouseButtons button)
        {
            if (button == MouseButtons.Left)
                leftMouseDown = true;
        }

        public static void MouseUp(MouseButtons button)
        {
            if (button == MouseButtons.Left)
                leftMouseDown = false;
        }

        public static bool IsMouseLeftDown() => leftMouseDown;

        public static bool IsMouseLeftJustClicked() =>
            leftMouseDown && !leftMousePreviouslyDown;

        // --- General Update & Reset ---

        public static void Update()
        {
            // Copy currentKeys into previousKeys
            foreach (var key in currentKeys.Keys.ToList())
                previousKeys[key] = currentKeys[key];

            // Update mouse state
            leftMousePreviouslyDown = leftMouseDown;
        }

        public static void ResetKeys()
        {
            currentKeys.Clear();
            previousKeys.Clear();
            leftMouseDown = false;
            leftMousePreviouslyDown = false;
        }
    }
}
