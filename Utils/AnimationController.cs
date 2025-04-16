namespace StyxEngine.Utils
{
    public class AnimationController
    {
        private PictureBox target;
        private Dictionary<string, Image> animations = new();
        private string currentAnimation = "";

        public AnimationController(PictureBox pictureBox)
        {
            target = pictureBox;
        }

        public void AddAnimation(string name, Image gif)
        {
            animations[name] = gif;
        }

        public void Play(string name)
        {
            if (name != currentAnimation)
            {
                currentAnimation = name;

                target.Image = (Image)animations[name].Clone();

            }
        }
    }
}
