using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StyxEngine.Scenes;

namespace StyxEngine
{
    public partial class TicTacToeForm : Form
    {
        private TicTacToeLogic gameLogic = new TicTacToeLogic();
        public int scoreX = 0;
        public int scoreO = 0;
        public int scoreDraw = 0;

        public TicTacToeForm()
        {
            InitializeComponent();
        }

        private void TicTacToeForm_Load(object sender, EventArgs e)
        {
            BoxGrid1.Tag = 0;
            BoxGrid2.Tag = 1;
            BoxGrid3.Tag = 2;
            BoxGrid4.Tag = 3;
            BoxGrid5.Tag = 4;
            BoxGrid6.Tag = 5;
            BoxGrid7.Tag = 6;
            BoxGrid8.Tag = 7;
            BoxGrid9.Tag = 8;

            // Add event handlers dynamically
            BoxGrid1.Click += BoxGrid_Click;
            BoxGrid2.Click += BoxGrid_Click;
            BoxGrid3.Click += BoxGrid_Click;
            BoxGrid4.Click += BoxGrid_Click;
            BoxGrid5.Click += BoxGrid_Click;
            BoxGrid6.Click += BoxGrid_Click;
            BoxGrid7.Click += BoxGrid_Click;
            BoxGrid8.Click += BoxGrid_Click;
            BoxGrid9.Click += BoxGrid_Click;
        }

        private void BoxGrid_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            // Get the index of the button
            int index = Convert.ToInt32(btn.Tag);

            // Pass the button and index to TicTacToeLogic
            gameLogic.BtnClicked(btn, index, this); // Pass 'this' to update scores in form
        }

        private void ResetScoreBtn_Click(object sender, EventArgs e)
        {
            PlayerXScore.Text = $"0";
            PlayerOScore.Text = $"0";
            PlayerDrawScore.Text = $"0";
        }
        
        private void ExitBtn_Click(object sender, EventArgs e)
        {

        }

        public void ResetScene()
        {
            BoxGrid1.BackgroundImage = null;
            BoxGrid2.BackgroundImage = null;
            BoxGrid3.BackgroundImage = null;
            BoxGrid4.BackgroundImage = null;
            BoxGrid5.BackgroundImage = null;
            BoxGrid6.BackgroundImage = null;
            BoxGrid7.BackgroundImage = null;
            BoxGrid8.BackgroundImage = null;
            BoxGrid9.BackgroundImage = null;

            gameLogic.ResetGame(); // Reset game logic state
        }
    }
}
