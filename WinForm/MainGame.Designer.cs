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
            rightAttackHitBox = new PictureBox();
            leftAttackHitBox = new PictureBox();
            DashCooldownBar = new ProgressBar();
            playerHealthBar = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerHitBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightAttackHitBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leftAttackHitBox).BeginInit();
            SuspendLayout();
            // 
            // Player
            // 
            Player.BackColor = Color.Transparent;
            Player.Image = Properties.PlayerResources._CrouchRight;
            Player.InitialImage = null;
            Player.Location = new Point(12, 49);
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
            playerHitBox.Location = new Point(96, 132);
            playerHitBox.Name = "playerHitBox";
            playerHitBox.Size = new Size(49, 77);
            playerHitBox.SizeMode = PictureBoxSizeMode.Zoom;
            playerHitBox.TabIndex = 11;
            playerHitBox.TabStop = false;
            // 
            // rightAttackHitBox
            // 
            rightAttackHitBox.Enabled = false;
            rightAttackHitBox.Location = new Point(153, 128);
            rightAttackHitBox.Name = "rightAttackHitBox";
            rightAttackHitBox.Size = new Size(94, 81);
            rightAttackHitBox.TabIndex = 35;
            rightAttackHitBox.TabStop = false;
            // 
            // leftAttackHitBox
            // 
            leftAttackHitBox.Enabled = false;
            leftAttackHitBox.Location = new Point(16, 128);
            leftAttackHitBox.Name = "leftAttackHitBox";
            leftAttackHitBox.Size = new Size(94, 81);
            leftAttackHitBox.TabIndex = 36;
            leftAttackHitBox.TabStop = false;
            // 
            // DashCooldownBar
            // 
            DashCooldownBar.BackColor = Color.Red;
            DashCooldownBar.ForeColor = Color.LightGreen;
            DashCooldownBar.Location = new Point(12, 36);
            DashCooldownBar.Name = "DashCooldownBar";
            DashCooldownBar.Size = new Size(235, 10);
            DashCooldownBar.Step = 100;
            DashCooldownBar.Style = ProgressBarStyle.Continuous;
            DashCooldownBar.TabIndex = 37;
            DashCooldownBar.Value = 100;
            // 
            // playerHealthBar
            // 
            playerHealthBar.BackColor = Color.Red;
            playerHealthBar.ForeColor = Color.Purple;
            playerHealthBar.Location = new Point(12, 12);
            playerHealthBar.Name = "playerHealthBar";
            playerHealthBar.Size = new Size(307, 18);
            playerHealthBar.Step = 100;
            playerHealthBar.Style = ProgressBarStyle.Continuous;
            playerHealthBar.TabIndex = 34;
            playerHealthBar.Value = 100;
            // 
            // MainGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1350, 729);
            Controls.Add(DashCooldownBar);
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
        public PictureBox leftAttackHitBox;
        public PictureBox rightAttackHitBox;
        public ProgressBar DashCooldownBar;
        public ProgressBar playerHealthBar;
    }
}