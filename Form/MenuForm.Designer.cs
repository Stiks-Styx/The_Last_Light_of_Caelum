namespace StyxEngine
{
    partial class MenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            panel1 = new Panel();
            BtnExit = new Button();
            BtnCredits = new Button();
            BtnSettings = new Button();
            BtnTabs = new TabControl();
            Btn1Player = new TabPage();
            Panel1Player = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox15 = new PictureBox();
            Btn2Player = new TabPage();
            Panel2Player = new FlowLayoutPanel();
            pictureBox5 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            Btn3_4Player = new TabPage();
            Panel3_4Player = new FlowLayoutPanel();
            pictureBox10 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox13 = new PictureBox();
            pictureBox14 = new PictureBox();
            pictureBox2 = new PictureBox();
            Title = new Label();
            panel1.SuspendLayout();
            BtnTabs.SuspendLayout();
            Btn1Player.SuspendLayout();
            Panel1Player.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            Btn2Player.SuspendLayout();
            Panel2Player.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            Btn3_4Player.SuspendLayout();
            Panel3_4Player.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(BtnExit);
            panel1.Controls.Add(BtnCredits);
            panel1.Controls.Add(BtnSettings);
            panel1.Controls.Add(BtnTabs);
            panel1.Controls.Add(Title);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(740, 509);
            panel1.TabIndex = 0;
            // 
            // BtnExit
            // 
            BtnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnExit.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            BtnExit.Location = new Point(622, 84);
            BtnExit.Margin = new Padding(0);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(101, 37);
            BtnExit.TabIndex = 5;
            BtnExit.Text = "Exit";
            BtnExit.UseVisualStyleBackColor = true;
            // 
            // BtnCredits
            // 
            BtnCredits.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnCredits.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            BtnCredits.Location = new Point(622, 47);
            BtnCredits.Margin = new Padding(0);
            BtnCredits.Name = "BtnCredits";
            BtnCredits.Size = new Size(101, 37);
            BtnCredits.TabIndex = 4;
            BtnCredits.Text = "Credits";
            BtnCredits.UseVisualStyleBackColor = true;
            // 
            // BtnSettings
            // 
            BtnSettings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSettings.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            BtnSettings.Location = new Point(622, 10);
            BtnSettings.Margin = new Padding(0);
            BtnSettings.Name = "BtnSettings";
            BtnSettings.Size = new Size(101, 37);
            BtnSettings.TabIndex = 3;
            BtnSettings.Text = "Settings";
            BtnSettings.UseVisualStyleBackColor = true;
            // 
            // BtnTabs
            // 
            BtnTabs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnTabs.Controls.Add(Btn1Player);
            BtnTabs.Controls.Add(Btn2Player);
            BtnTabs.Controls.Add(Btn3_4Player);
            BtnTabs.Cursor = Cursors.Hand;
            BtnTabs.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            BtnTabs.ItemSize = new Size(110, 50);
            BtnTabs.Location = new Point(13, 124);
            BtnTabs.Name = "BtnTabs";
            BtnTabs.SelectedIndex = 0;
            BtnTabs.Size = new Size(714, 372);
            BtnTabs.SizeMode = TabSizeMode.Fixed;
            BtnTabs.TabIndex = 2;
            // 
            // Btn1Player
            // 
            Btn1Player.BorderStyle = BorderStyle.Fixed3D;
            Btn1Player.Controls.Add(Panel1Player);
            Btn1Player.Cursor = Cursors.Hand;
            Btn1Player.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            Btn1Player.Location = new Point(4, 54);
            Btn1Player.Name = "Btn1Player";
            Btn1Player.Padding = new Padding(3);
            Btn1Player.Size = new Size(706, 314);
            Btn1Player.TabIndex = 0;
            Btn1Player.Text = "1 Player";
            Btn1Player.UseVisualStyleBackColor = true;
            // 
            // Panel1Player
            // 
            Panel1Player.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Panel1Player.Controls.Add(pictureBox1);
            Panel1Player.Controls.Add(pictureBox4);
            Panel1Player.Controls.Add(pictureBox15);
            Panel1Player.Location = new Point(6, 6);
            Panel1Player.Name = "Panel1Player";
            Panel1Player.Padding = new Padding(10);
            Panel1Player.Size = new Size(690, 303);
            Panel1Player.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(13, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.InitialImage = (Image)resources.GetObject("pictureBox4.InitialImage");
            pictureBox4.Location = new Point(169, 13);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(150, 150);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox15
            // 
            pictureBox15.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox15.Image = (Image)resources.GetObject("pictureBox15.Image");
            pictureBox15.InitialImage = (Image)resources.GetObject("pictureBox15.InitialImage");
            pictureBox15.Location = new Point(325, 13);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(150, 150);
            pictureBox15.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox15.TabIndex = 4;
            pictureBox15.TabStop = false;
            // 
            // Btn2Player
            // 
            Btn2Player.BorderStyle = BorderStyle.Fixed3D;
            Btn2Player.Controls.Add(Panel2Player);
            Btn2Player.Cursor = Cursors.Hand;
            Btn2Player.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            Btn2Player.Location = new Point(4, 54);
            Btn2Player.Name = "Btn2Player";
            Btn2Player.Padding = new Padding(3);
            Btn2Player.Size = new Size(706, 314);
            Btn2Player.TabIndex = 1;
            Btn2Player.Text = "2 Player";
            Btn2Player.UseVisualStyleBackColor = true;
            // 
            // Panel2Player
            // 
            Panel2Player.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Panel2Player.Controls.Add(pictureBox5);
            Panel2Player.Controls.Add(pictureBox7);
            Panel2Player.Controls.Add(pictureBox8);
            Panel2Player.Controls.Add(pictureBox9);
            Panel2Player.Location = new Point(6, 6);
            Panel2Player.Name = "Panel2Player";
            Panel2Player.Padding = new Padding(10);
            Panel2Player.Size = new Size(690, 303);
            Panel2Player.TabIndex = 1;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.InitialImage = (Image)resources.GetObject("pictureBox5.InitialImage");
            pictureBox5.Location = new Point(13, 13);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(150, 150);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.InitialImage = (Image)resources.GetObject("pictureBox7.InitialImage");
            pictureBox7.Location = new Point(169, 13);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(150, 150);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 2;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.InitialImage = (Image)resources.GetObject("pictureBox8.InitialImage");
            pictureBox8.Location = new Point(325, 13);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(150, 150);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 3;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.InitialImage = (Image)resources.GetObject("pictureBox9.InitialImage");
            pictureBox9.Location = new Point(481, 13);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(150, 150);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 4;
            pictureBox9.TabStop = false;
            // 
            // Btn3_4Player
            // 
            Btn3_4Player.BorderStyle = BorderStyle.Fixed3D;
            Btn3_4Player.Controls.Add(Panel3_4Player);
            Btn3_4Player.Cursor = Cursors.Hand;
            Btn3_4Player.Location = new Point(4, 54);
            Btn3_4Player.Name = "Btn3_4Player";
            Btn3_4Player.Padding = new Padding(3);
            Btn3_4Player.Size = new Size(706, 314);
            Btn3_4Player.TabIndex = 2;
            Btn3_4Player.Text = "3-4 Player";
            Btn3_4Player.UseVisualStyleBackColor = true;
            // 
            // Panel3_4Player
            // 
            Panel3_4Player.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Panel3_4Player.Controls.Add(pictureBox10);
            Panel3_4Player.Controls.Add(pictureBox11);
            Panel3_4Player.Controls.Add(pictureBox12);
            Panel3_4Player.Controls.Add(pictureBox13);
            Panel3_4Player.Controls.Add(pictureBox14);
            Panel3_4Player.Controls.Add(pictureBox2);
            Panel3_4Player.Location = new Point(6, 6);
            Panel3_4Player.Name = "Panel3_4Player";
            Panel3_4Player.Padding = new Padding(10);
            Panel3_4Player.Size = new Size(690, 303);
            Panel3_4Player.TabIndex = 1;
            // 
            // pictureBox10
            // 
            pictureBox10.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.InitialImage = (Image)resources.GetObject("pictureBox10.InitialImage");
            pictureBox10.Location = new Point(13, 13);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(150, 150);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 0;
            pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.InitialImage = (Image)resources.GetObject("pictureBox11.InitialImage");
            pictureBox11.Location = new Point(169, 13);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(150, 150);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 1;
            pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            pictureBox12.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.InitialImage = (Image)resources.GetObject("pictureBox12.InitialImage");
            pictureBox12.Location = new Point(325, 13);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(150, 150);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 2;
            pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            pictureBox13.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox13.Image = (Image)resources.GetObject("pictureBox13.Image");
            pictureBox13.InitialImage = (Image)resources.GetObject("pictureBox13.InitialImage");
            pictureBox13.Location = new Point(481, 13);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(150, 150);
            pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox13.TabIndex = 3;
            pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            pictureBox14.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox14.Image = (Image)resources.GetObject("pictureBox14.Image");
            pictureBox14.InitialImage = (Image)resources.GetObject("pictureBox14.InitialImage");
            pictureBox14.Location = new Point(13, 169);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(150, 150);
            pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox14.TabIndex = 4;
            pictureBox14.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(169, 169);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(150, 150);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Dock = DockStyle.Fill;
            Title.Font = new Font("Segoe UI", 50F, FontStyle.Bold);
            Title.Location = new Point(10, 10);
            Title.Name = "Title";
            Title.Size = new Size(358, 89);
            Title.TabIndex = 1;
            Title.Text = "GameTitle";
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 533);
            Controls.Add(panel1);
            Name = "MenuForm";
            Text = "Menu";
            Load += MenuForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            BtnTabs.ResumeLayout(false);
            Btn1Player.ResumeLayout(false);
            Panel1Player.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            Btn2Player.ResumeLayout(false);
            Panel2Player.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            Btn3_4Player.ResumeLayout(false);
            Panel3_4Player.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label Title;
        private TabControl BtnTabs;
        private TabPage Btn1Player;
        private TabPage Btn2Player;
        private Button BtnSettings;
        private TabPage Btn3_4Player;
        private Button BtnExit;
        private Button BtnCredits;
        private FlowLayoutPanel Panel2Player;
        private PictureBox pictureBox5;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private FlowLayoutPanel Panel3_4Player;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private FlowLayoutPanel Panel1Player;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox15;
        private PictureBox pictureBox2;
    }
}
