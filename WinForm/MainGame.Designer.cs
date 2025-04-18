namespace StyxEngine
{
    partial class MainGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Player = new PictureBox();
            playerHitBox = new PictureBox();
            playerHealthBar = new ProgressBar();
            rightAttackHitBox = new PictureBox();
            leftAttackHitBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerHitBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightAttackHitBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftAttackHitBox).BeginInit();
            SuspendLayout();
            // 
            // Player
            // 
            Player.BackColor = Color.DimGray;
            Player.Image = Properties.PlayerResources._CrouchRight;
            Player.InitialImage = null;
            Player.Location = new Point(13, 38);
            Player.Margin = new Padding(0);
            Player.Name = "Player";
            Player.Size = new Size(240, 160);
            Player.SizeMode = PictureBoxSizeMode.StretchImage;
            Player.TabIndex = 0;
            Player.TabStop = false;
            // 
            // playerHitBox
            // 
            playerHitBox.BackColor = Color.Tomato;
            playerHitBox.ErrorImage = null;
            playerHitBox.InitialImage = null;
            playerHitBox.Location = new Point(100, 121);
            playerHitBox.Name = "playerHitBox";
            playerHitBox.Size = new Size(42, 77);
            playerHitBox.SizeMode = PictureBoxSizeMode.Zoom;
            playerHitBox.TabIndex = 11;
            playerHitBox.TabStop = false;
            // 
            // playerHealthBar
            // 
            playerHealthBar.BackColor = Color.Red;
            playerHealthBar.ForeColor = Color.Lime;
            playerHealthBar.Location = new Point(12, 12);
            playerHealthBar.Name = "playerHealthBar";
            playerHealthBar.Size = new Size(307, 18);
            playerHealthBar.Step = 100;
            playerHealthBar.Style = ProgressBarStyle.Continuous;
            playerHealthBar.TabIndex = 34;
            playerHealthBar.Value = 100;
            // 
            // rightAttackHitBox
            // 
            rightAttackHitBox.Location = new Point(154, 117);
            rightAttackHitBox.Name = "rightAttackHitBox";
            rightAttackHitBox.Size = new Size(94, 81);
            rightAttackHitBox.TabIndex = 35;
            rightAttackHitBox.TabStop = false;
            // 
            // leftAttackHitBox
            // 
            leftAttackHitBox.Location = new Point(17, 117);
            leftAttackHitBox.Name = "leftAttackHitBox";
            leftAttackHitBox.Size = new Size(94, 81);
            leftAttackHitBox.TabIndex = 36;
            leftAttackHitBox.TabStop = false;
            // 
            // MainGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1350, 729);
            Controls.Add(leftAttackHitBox);
            Controls.Add(rightAttackHitBox);
            Controls.Add(playerHealthBar);
            Controls.Add(playerHitBox);
            Controls.Add(Player);
            Name = "MainGame";
            Text = "The Last Light of Caelum";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)Player).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerHitBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightAttackHitBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)leftAttackHitBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public PictureBox Player;
        public PictureBox playerHitBox;
        private Panel panel3;
        public ProgressBar playerHealthBar;
        public PictureBox leftAttackHitBox;
        public PictureBox rightAttackHitBox;
    }
}