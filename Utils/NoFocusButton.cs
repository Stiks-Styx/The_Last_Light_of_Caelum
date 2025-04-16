using System.Windows.Forms;

namespace StyxEngine.Utils
{
    public class NoFocusButton : Button
    {
        protected override bool ShowFocusCues => false; // Hide focus border

        protected override void OnGotFocus(EventArgs e)
        {
            this.Parent?.Focus(); // Immediately return focus to the form
        }
    }
}