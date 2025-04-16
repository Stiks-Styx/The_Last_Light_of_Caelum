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
            PlayerHealthBar = new ProgressBar();
            PlayerName = new Label();
            PlayerHealthAmount = new Label();
            panel1 = new Panel();
            _playerPositionDebug = new Label();
            _expDebug = new Label();
            _levelDebug = new Label();
            _playerDirectionDebug = new Label();
            _playerHealthDebug = new Label();
            _collisionStatusDebug = new Label();
            _collisionTypeDebug = new Label();
            label1 = new Label();
            wall1 = new PictureBox();
            wall2 = new PictureBox();
            enemy = new PictureBox();
            item1 = new PictureBox();
            playerHitBox = new PictureBox();
            wall3 = new PictureBox();
            wall4 = new PictureBox();
            wall7 = new PictureBox();
            wall6 = new PictureBox();
            wall5 = new PictureBox();
            wall10 = new PictureBox();
            wall9 = new PictureBox();
            wall8 = new PictureBox();
            wall13 = new PictureBox();
            wall12 = new PictureBox();
            wall11 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Player).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)wall1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)item1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerHitBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wall11).BeginInit();
            SuspendLayout();
            // 
            // Player
            // 
            Player.BackColor = Color.Transparent;
            Player.Location = new Point(509, 506);
            Player.Margin = new Padding(0);
            Player.Name = "Player";
            Player.Size = new Size(240, 160);
            Player.SizeMode = PictureBoxSizeMode.StretchImage;
            Player.TabIndex = 0;
            Player.TabStop = false;
            // 
            // PlayerHealthBar
            // 
            PlayerHealthBar.BackColor = Color.Red;
            PlayerHealthBar.ForeColor = Color.Lime;
            PlayerHealthBar.Location = new Point(12, 30);
            PlayerHealthBar.Name = "PlayerHealthBar";
            PlayerHealthBar.Size = new Size(307, 18);
            PlayerHealthBar.Step = 100;
            PlayerHealthBar.Style = ProgressBarStyle.Continuous;
            PlayerHealthBar.TabIndex = 1;
            PlayerHealthBar.Value = 100;
            // 
            // PlayerName
            // 
            PlayerName.Location = new Point(12, 7);
            PlayerName.Name = "PlayerName";
            PlayerName.Size = new Size(307, 21);
            PlayerName.TabIndex = 2;
            PlayerName.Text = "PlayerNameDefault";
            // 
            // PlayerHealthAmount
            // 
            PlayerHealthAmount.Location = new Point(12, 51);
            PlayerHealthAmount.Name = "PlayerHealthAmount";
            PlayerHealthAmount.Size = new Size(307, 21);
            PlayerHealthAmount.TabIndex = 3;
            PlayerHealthAmount.Text = "100/100";
            PlayerHealthAmount.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(_playerPositionDebug);
            panel1.Controls.Add(_expDebug);
            panel1.Controls.Add(_levelDebug);
            panel1.Controls.Add(_playerDirectionDebug);
            panel1.Controls.Add(_playerHealthDebug);
            panel1.Controls.Add(_collisionStatusDebug);
            panel1.Controls.Add(_collisionTypeDebug);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1145, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(193, 348);
            panel1.TabIndex = 4;
            // 
            // _playerPositionDebug
            // 
            _playerPositionDebug.Font = new Font("Segoe UI", 11F);
            _playerPositionDebug.Location = new Point(0, 27);
            _playerPositionDebug.Name = "_playerPositionDebug";
            _playerPositionDebug.Size = new Size(193, 27);
            _playerPositionDebug.TabIndex = 9;
            _playerPositionDebug.Text = "Player Position:";
            _playerPositionDebug.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _expDebug
            // 
            _expDebug.Font = new Font("Segoe UI", 11F);
            _expDebug.Location = new Point(0, 243);
            _expDebug.Name = "_expDebug";
            _expDebug.Size = new Size(193, 27);
            _expDebug.TabIndex = 8;
            _expDebug.Text = "Exp:";
            _expDebug.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _levelDebug
            // 
            _levelDebug.Font = new Font("Segoe UI", 11F);
            _levelDebug.Location = new Point(0, 216);
            _levelDebug.Name = "_levelDebug";
            _levelDebug.Size = new Size(193, 27);
            _levelDebug.TabIndex = 7;
            _levelDebug.Text = "Level:";
            _levelDebug.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _playerDirectionDebug
            // 
            _playerDirectionDebug.Font = new Font("Segoe UI", 11F);
            _playerDirectionDebug.Location = new Point(0, 81);
            _playerDirectionDebug.Name = "_playerDirectionDebug";
            _playerDirectionDebug.Size = new Size(193, 27);
            _playerDirectionDebug.TabIndex = 5;
            _playerDirectionDebug.Text = "Player Direction:";
            _playerDirectionDebug.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _playerHealthDebug
            // 
            _playerHealthDebug.Font = new Font("Segoe UI", 11F);
            _playerHealthDebug.Location = new Point(0, 54);
            _playerHealthDebug.Name = "_playerHealthDebug";
            _playerHealthDebug.Size = new Size(193, 27);
            _playerHealthDebug.TabIndex = 4;
            _playerHealthDebug.Text = "Player Health:";
            _playerHealthDebug.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _collisionStatusDebug
            // 
            _collisionStatusDebug.Font = new Font("Segoe UI", 11F);
            _collisionStatusDebug.Location = new Point(0, 162);
            _collisionStatusDebug.Name = "_collisionStatusDebug";
            _collisionStatusDebug.Size = new Size(193, 27);
            _collisionStatusDebug.TabIndex = 2;
            _collisionStatusDebug.Text = "Collision Status:";
            _collisionStatusDebug.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _collisionTypeDebug
            // 
            _collisionTypeDebug.Font = new Font("Segoe UI", 11F);
            _collisionTypeDebug.Location = new Point(0, 135);
            _collisionTypeDebug.Name = "_collisionTypeDebug";
            _collisionTypeDebug.Size = new Size(193, 27);
            _collisionTypeDebug.TabIndex = 1;
            _collisionTypeDebug.Text = "Collision Type: ";
            _collisionTypeDebug.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(193, 27);
            label1.TabIndex = 0;
            label1.Text = "Debug Window";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // wall1
            // 
            wall1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            wall1.BackColor = Color.Black;
            wall1.Location = new Point(198, 637);
            wall1.Margin = new Padding(0);
            wall1.Name = "wall1";
            wall1.Size = new Size(32, 32);
            wall1.TabIndex = 7;
            wall1.TabStop = false;
            // 
            // wall2
            // 
            wall2.BackColor = Color.SaddleBrown;
            wall2.Dock = DockStyle.Bottom;
            wall2.Location = new Point(0, 669);
            wall2.Margin = new Padding(0);
            wall2.Name = "wall2";
            wall2.Size = new Size(1350, 60);
            wall2.TabIndex = 8;
            wall2.TabStop = false;
            // 
            // enemy
            // 
            enemy.BackColor = Color.Blue;
            enemy.Location = new Point(343, 147);
            enemy.Margin = new Padding(0);
            enemy.Name = "enemy";
            enemy.Size = new Size(32, 32);
            enemy.SizeMode = PictureBoxSizeMode.StretchImage;
            enemy.TabIndex = 9;
            enemy.TabStop = false;
            // 
            // item1
            // 
            item1.BackColor = Color.Blue;
            item1.Location = new Point(201, 183);
            item1.Margin = new Padding(0);
            item1.Name = "item1";
            item1.Size = new Size(32, 32);
            item1.TabIndex = 10;
            item1.TabStop = false;
            // 
            // playerHitBox
            // 
            playerHitBox.BackColor = Color.Tomato;
            playerHitBox.ErrorImage = null;
            playerHitBox.InitialImage = null;
            playerHitBox.Location = new Point(597, 589);
            playerHitBox.Name = "playerHitBox";
            playerHitBox.Size = new Size(42, 77);
            playerHitBox.SizeMode = PictureBoxSizeMode.Zoom;
            playerHitBox.TabIndex = 11;
            playerHitBox.TabStop = false;
            playerHitBox.Visible = false;
            // 
            // wall3
            // 
            wall3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            wall3.BackColor = Color.Black;
            wall3.Location = new Point(230, 605);
            wall3.Margin = new Padding(0);
            wall3.Name = "wall3";
            wall3.Size = new Size(32, 32);
            wall3.TabIndex = 12;
            wall3.TabStop = false;
            wall3.Tag = "wall";
            // 
            // wall4
            // 
            wall4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            wall4.BackColor = Color.Black;
            wall4.Location = new Point(262, 573);
            wall4.Margin = new Padding(0);
            wall4.Name = "wall4";
            wall4.Size = new Size(32, 32);
            wall4.TabIndex = 13;
            wall4.TabStop = false;
            // 
            // wall7
            // 
            wall7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            wall7.BackColor = Color.Black;
            wall7.Location = new Point(430, 443);
            wall7.Margin = new Padding(0);
            wall7.Name = "wall7";
            wall7.Size = new Size(32, 32);
            wall7.TabIndex = 16;
            wall7.TabStop = false;
            // 
            // wall6
            // 
            wall6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            wall6.BackColor = Color.Black;
            wall6.Location = new Point(398, 475);
            wall6.Margin = new Padding(0);
            wall6.Name = "wall6";
            wall6.Size = new Size(32, 32);
            wall6.TabIndex = 15;
            wall6.TabStop = false;
            wall6.Tag = "wall";
            // 
            // wall5
            // 
            wall5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            wall5.BackColor = Color.Black;
            wall5.Location = new Point(366, 507);
            wall5.Margin = new Padding(0);
            wall5.Name = "wall5";
            wall5.Size = new Size(32, 32);
            wall5.TabIndex = 14;
            wall5.TabStop = false;
            // 
            // wall10
            // 
            wall10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            wall10.BackColor = Color.Black;
            wall10.Location = new Point(319, 340);
            wall10.Margin = new Padding(0);
            wall10.Name = "wall10";
            wall10.Size = new Size(32, 32);
            wall10.TabIndex = 19;
            wall10.TabStop = false;
            // 
            // wall9
            // 
            wall9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            wall9.BackColor = Color.Black;
            wall9.Location = new Point(287, 372);
            wall9.Margin = new Padding(0);
            wall9.Name = "wall9";
            wall9.Size = new Size(32, 32);
            wall9.TabIndex = 18;
            wall9.TabStop = false;
            wall9.Tag = "wall";
            // 
            // wall8
            // 
            wall8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            wall8.BackColor = Color.Black;
            wall8.Location = new Point(255, 404);
            wall8.Margin = new Padding(0);
            wall8.Name = "wall8";
            wall8.Size = new Size(32, 32);
            wall8.TabIndex = 17;
            wall8.TabStop = false;
            // 
            // wall13
            // 
            wall13.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            wall13.BackColor = Color.Black;
            wall13.Location = new Point(775, 402);
            wall13.Margin = new Padding(0);
            wall13.Name = "wall13";
            wall13.Size = new Size(32, 32);
            wall13.TabIndex = 22;
            wall13.TabStop = false;
            // 
            // wall12
            // 
            wall12.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            wall12.BackColor = Color.Black;
            wall12.Location = new Point(977, 402);
            wall12.Margin = new Padding(0);
            wall12.Name = "wall12";
            wall12.Size = new Size(32, 32);
            wall12.TabIndex = 21;
            wall12.TabStop = false;
            wall12.Tag = "wall";
            // 
            // wall11
            // 
            wall11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            wall11.BackColor = Color.Black;
            wall11.Location = new Point(565, 402);
            wall11.Margin = new Padding(0);
            wall11.Name = "wall11";
            wall11.Size = new Size(32, 32);
            wall11.TabIndex = 20;
            wall11.TabStop = false;
            // 
            // MainGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1350, 729);
            Controls.Add(wall13);
            Controls.Add(wall12);
            Controls.Add(wall11);
            Controls.Add(wall10);
            Controls.Add(wall9);
            Controls.Add(wall8);
            Controls.Add(wall7);
            Controls.Add(wall6);
            Controls.Add(wall5);
            Controls.Add(wall4);
            Controls.Add(wall3);
            Controls.Add(wall1);
            Controls.Add(playerHitBox);
            Controls.Add(item1);
            Controls.Add(enemy);
            Controls.Add(wall2);
            Controls.Add(panel1);
            Controls.Add(PlayerHealthAmount);
            Controls.Add(PlayerName);
            Controls.Add(PlayerHealthBar);
            Controls.Add(Player);
            Name = "MainGame";
            Text = "The Last Light of Caelum";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)Player).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)wall1).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall2).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy).EndInit();
            ((System.ComponentModel.ISupportInitialize)item1).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerHitBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall3).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall4).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall7).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall6).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall5).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall10).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall9).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall8).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall13).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall12).EndInit();
            ((System.ComponentModel.ISupportInitialize)wall11).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public PictureBox Player;
        public Label PlayerName;
        public ProgressBar PlayerHealthBar;
        public Label PlayerHealthAmount;
        private Label label1;
        public Panel panel1;
        public Label _collisionTypeDebug;
        public Label _collisionStatusDebug;
        public Label _playerHealthDebug;
        public Label _playerDirectionDebug;
        public Label _levelDebug;
        public Label _expDebug;
        public Label _playerPositionDebug;
        public PictureBox wall1;
        public PictureBox wall2;
        public PictureBox enemy;
        public PictureBox item1;
        public PictureBox playerHitBox;
        public PictureBox wall3;
        public PictureBox wall4;
        public PictureBox wall7;
        public PictureBox wall6;
        public PictureBox wall5;
        public PictureBox wall10;
        public PictureBox wall9;
        public PictureBox wall8;
        public PictureBox wall13;
        public PictureBox wall12;
        public PictureBox wall11;
        private Panel panel3;
    }
}