namespace StyxEngine
{
    partial class TicTacToeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToeForm));
            flowLayoutPanel2 = new FlowLayoutPanel();
            BoxGrid1 = new Button();
            BoxGrid2 = new Button();
            BoxGrid3 = new Button();
            BoxGrid4 = new Button();
            BoxGrid5 = new Button();
            BoxGrid6 = new Button();
            BoxGrid7 = new Button();
            BoxGrid8 = new Button();
            BoxGrid9 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ResetBtn = new Button();
            ExitBtn = new Button();
            ResultBox = new Label();
            label1 = new Label();
            label2 = new Label();
            PlayerXScore = new Label();
            PlayerOScore = new Label();
            label3 = new Label();
            PlayerDrawScore = new Label();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.None;
            flowLayoutPanel2.BackColor = Color.FromArgb(45, 8, 67);
            flowLayoutPanel2.BackgroundImage = (Image)resources.GetObject("flowLayoutPanel2.BackgroundImage");
            flowLayoutPanel2.BackgroundImageLayout = ImageLayout.Stretch;
            flowLayoutPanel2.Controls.Add(BoxGrid1);
            flowLayoutPanel2.Controls.Add(BoxGrid2);
            flowLayoutPanel2.Controls.Add(BoxGrid3);
            flowLayoutPanel2.Controls.Add(BoxGrid4);
            flowLayoutPanel2.Controls.Add(BoxGrid5);
            flowLayoutPanel2.Controls.Add(BoxGrid6);
            flowLayoutPanel2.Controls.Add(BoxGrid7);
            flowLayoutPanel2.Controls.Add(BoxGrid8);
            flowLayoutPanel2.Controls.Add(BoxGrid9);
            flowLayoutPanel2.Location = new Point(58, 231);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(15);
            flowLayoutPanel2.Size = new Size(288, 288);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // BoxGrid1
            // 
            BoxGrid1.BackColor = Color.FromArgb(90, 31, 118);
            BoxGrid1.BackgroundImageLayout = ImageLayout.Stretch;
            BoxGrid1.FlatAppearance.BorderSize = 0;
            BoxGrid1.FlatStyle = FlatStyle.Flat;
            BoxGrid1.Location = new Point(18, 18);
            BoxGrid1.Name = "BoxGrid1";
            BoxGrid1.Size = new Size(80, 80);
            BoxGrid1.TabIndex = 1;
            BoxGrid1.UseVisualStyleBackColor = false;
            BoxGrid1.Click += BoxGrid_Click;
            // 
            // BoxGrid2
            // 
            BoxGrid2.BackColor = Color.FromArgb(90, 31, 118);
            BoxGrid2.BackgroundImageLayout = ImageLayout.Stretch;
            BoxGrid2.FlatAppearance.BorderSize = 0;
            BoxGrid2.FlatStyle = FlatStyle.Flat;
            BoxGrid2.Location = new Point(104, 18);
            BoxGrid2.Name = "BoxGrid2";
            BoxGrid2.Size = new Size(80, 80);
            BoxGrid2.TabIndex = 2;
            BoxGrid2.UseVisualStyleBackColor = false;
            BoxGrid2.Click += BoxGrid_Click;
            // 
            // BoxGrid3
            // 
            BoxGrid3.BackColor = Color.FromArgb(90, 31, 118);
            BoxGrid3.FlatAppearance.BorderSize = 0;
            BoxGrid3.FlatStyle = FlatStyle.Flat;
            BoxGrid3.Location = new Point(190, 18);
            BoxGrid3.Name = "BoxGrid3";
            BoxGrid3.Size = new Size(80, 80);
            BoxGrid3.TabIndex = 3;
            BoxGrid3.UseVisualStyleBackColor = false;
            BoxGrid3.Click += BoxGrid_Click;
            // 
            // BoxGrid4
            // 
            BoxGrid4.BackColor = Color.FromArgb(90, 31, 118);
            BoxGrid4.FlatAppearance.BorderSize = 0;
            BoxGrid4.FlatStyle = FlatStyle.Flat;
            BoxGrid4.Location = new Point(18, 104);
            BoxGrid4.Name = "BoxGrid4";
            BoxGrid4.Size = new Size(80, 80);
            BoxGrid4.TabIndex = 4;
            BoxGrid4.UseVisualStyleBackColor = false;
            BoxGrid4.Click += BoxGrid_Click;
            // 
            // BoxGrid5
            // 
            BoxGrid5.BackColor = Color.FromArgb(90, 31, 118);
            BoxGrid5.FlatAppearance.BorderSize = 0;
            BoxGrid5.FlatStyle = FlatStyle.Flat;
            BoxGrid5.Location = new Point(104, 104);
            BoxGrid5.Name = "BoxGrid5";
            BoxGrid5.Size = new Size(80, 80);
            BoxGrid5.TabIndex = 6;
            BoxGrid5.UseVisualStyleBackColor = false;
            BoxGrid5.Click += BoxGrid_Click;
            // 
            // BoxGrid6
            // 
            BoxGrid6.BackColor = Color.FromArgb(90, 31, 118);
            BoxGrid6.FlatAppearance.BorderSize = 0;
            BoxGrid6.FlatStyle = FlatStyle.Flat;
            BoxGrid6.Location = new Point(190, 104);
            BoxGrid6.Name = "BoxGrid6";
            BoxGrid6.Size = new Size(80, 80);
            BoxGrid6.TabIndex = 7;
            BoxGrid6.UseVisualStyleBackColor = false;
            BoxGrid6.Click += BoxGrid_Click;
            // 
            // BoxGrid7
            // 
            BoxGrid7.BackColor = Color.FromArgb(90, 31, 118);
            BoxGrid7.FlatAppearance.BorderSize = 0;
            BoxGrid7.FlatStyle = FlatStyle.Flat;
            BoxGrid7.Location = new Point(18, 190);
            BoxGrid7.Name = "BoxGrid7";
            BoxGrid7.Size = new Size(80, 80);
            BoxGrid7.TabIndex = 8;
            BoxGrid7.UseVisualStyleBackColor = false;
            BoxGrid7.Click += BoxGrid_Click;
            // 
            // BoxGrid8
            // 
            BoxGrid8.BackColor = Color.FromArgb(90, 31, 118);
            BoxGrid8.FlatAppearance.BorderSize = 0;
            BoxGrid8.FlatStyle = FlatStyle.Flat;
            BoxGrid8.Location = new Point(104, 190);
            BoxGrid8.Name = "BoxGrid8";
            BoxGrid8.Size = new Size(80, 80);
            BoxGrid8.TabIndex = 5;
            BoxGrid8.UseVisualStyleBackColor = false;
            BoxGrid8.Click += BoxGrid_Click;
            // 
            // BoxGrid9
            // 
            BoxGrid9.BackColor = Color.FromArgb(90, 31, 118);
            BoxGrid9.FlatAppearance.BorderSize = 0;
            BoxGrid9.FlatStyle = FlatStyle.Flat;
            BoxGrid9.Location = new Point(190, 190);
            BoxGrid9.Name = "BoxGrid9";
            BoxGrid9.Size = new Size(80, 80);
            BoxGrid9.TabIndex = 9;
            BoxGrid9.UseVisualStyleBackColor = false;
            BoxGrid9.Click += BoxGrid_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(29, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 100);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(153, 42);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(101, 100);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(277, 42);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(101, 100);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(76, 164);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(252, 52);
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // ResetBtn
            // 
            ResetBtn.FlatAppearance.BorderSize = 0;
            ResetBtn.FlatStyle = FlatStyle.Flat;
            ResetBtn.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            ResetBtn.ForeColor = SystemColors.Info;
            ResetBtn.Location = new Point(91, 536);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(220, 53);
            ResetBtn.TabIndex = 8;
            ResetBtn.Text = "Reset Scores";
            ResetBtn.UseVisualStyleBackColor = true;
            ResetBtn.Click += ResetScoreBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.FlatAppearance.BorderSize = 0;
            ExitBtn.FlatStyle = FlatStyle.Flat;
            ExitBtn.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            ExitBtn.Location = new Point(162, 618);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(80, 70);
            ExitBtn.TabIndex = 9;
            ExitBtn.Text = "X";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // ResultBox
            // 
            ResultBox.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            ResultBox.ForeColor = SystemColors.Info;
            ResultBox.Location = new Point(91, 180);
            ResultBox.Name = "ResultBox";
            ResultBox.Size = new Size(220, 20);
            ResultBox.TabIndex = 11;
            ResultBox.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(29, 52);
            label1.Name = "label1";
            label1.Size = new Size(101, 23);
            label1.TabIndex = 12;
            label1.Text = "Player X";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Info;
            label2.Location = new Point(277, 52);
            label2.Name = "label2";
            label2.Size = new Size(101, 23);
            label2.TabIndex = 13;
            label2.Text = "Player O";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PlayerXScore
            // 
            PlayerXScore.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            PlayerXScore.ForeColor = SystemColors.Info;
            PlayerXScore.Location = new Point(29, 90);
            PlayerXScore.Name = "PlayerXScore";
            PlayerXScore.Size = new Size(101, 23);
            PlayerXScore.TabIndex = 14;
            PlayerXScore.Text = "0";
            PlayerXScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PlayerOScore
            // 
            PlayerOScore.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            PlayerOScore.ForeColor = SystemColors.Info;
            PlayerOScore.Location = new Point(277, 90);
            PlayerOScore.Name = "PlayerOScore";
            PlayerOScore.Size = new Size(101, 23);
            PlayerOScore.TabIndex = 15;
            PlayerOScore.Text = "0";
            PlayerOScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Info;
            label3.Location = new Point(153, 52);
            label3.Name = "label3";
            label3.Size = new Size(101, 23);
            label3.TabIndex = 16;
            label3.Text = "Draw";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PlayerDrawScore
            // 
            PlayerDrawScore.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            PlayerDrawScore.ForeColor = SystemColors.Info;
            PlayerDrawScore.Location = new Point(153, 90);
            PlayerDrawScore.Name = "PlayerDrawScore";
            PlayerDrawScore.Size = new Size(101, 23);
            PlayerDrawScore.TabIndex = 17;
            PlayerDrawScore.Text = "0";
            PlayerDrawScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TicTacToeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 8, 67);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(404, 681);
            Controls.Add(PlayerDrawScore);
            Controls.Add(label3);
            Controls.Add(PlayerOScore);
            Controls.Add(PlayerXScore);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ResultBox);
            Controls.Add(ExitBtn);
            Controls.Add(ResetBtn);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(flowLayoutPanel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "TicTacToeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TicTacToe";
            Load += TicTacToeForm_Load;
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel2;
        private Button BoxGrid1;
        private Button BoxGrid2;
        private Button BoxGrid3;
        private Button BoxGrid4;
        private Button BoxGrid5;
        private Button BoxGrid6;
        private Button BoxGrid7;
        private Button BoxGrid8;
        private Button BoxGrid9;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button ResetBtn;
        private Button ExitBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        public Label PlayerXScore;
        public Label PlayerOScore;
        public Label PlayerDrawScore;
        public Label ResultBox;
    }
}