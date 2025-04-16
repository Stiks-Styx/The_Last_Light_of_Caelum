using System;
using System.Drawing;
using System.Windows.Forms;

namespace StyxEngine.Scenes
{
    public class TicTacToeLogic
    {
        private Image imageO = Image.FromFile("Assets\\O.png");
        private Image imageX = Image.FromFile("Assets\\X.png");
        private int turn = 0;  // Initialize turn counter
        private int[] Grid;

        public TicTacToeLogic()
        {
            ResetGame();
        }

        public void SetX(Button btn)
        {
            btn.BackgroundImage = imageX;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
        }

        public void SetO(Button btn)
        {
            btn.BackgroundImage = imageO;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
        }

        public async void BtnClicked(Button btn, int index, TicTacToeForm form)
        {
            if (btn.BackgroundImage != null || CheckWinner() != -1) return; // Prevent further moves if game ends

            if (turn % 2 == 0)
            {
                SetX(btn);
                Grid[index] = 1; // X is represented by 1
            }
            else
            {
                SetO(btn);
                Grid[index] = 0; // O is represented by 0
            }

            turn++; // Switch turn

            int winner = CheckWinner();
            if (winner == 1)
            {
                form.ResultBox.Text = "Game Over! Player X Won";
                form.scoreX++;
                form.PlayerXScore.Text = $"{form.scoreX}";
                DisableButtons(form);
                await AutoReset(form);
            }
            else if (winner == 0)
            {
                form.ResultBox.Text = "Game Over! Player O Won";
                form.scoreO++;
                form.PlayerOScore.Text = $"{form.scoreO}";
                DisableButtons(form);
                await AutoReset(form);
            }
            else if (turn == 9)
            {
                form.ResultBox.Text = "It's a Draw";
                form.scoreDraw++;
                form.PlayerDrawScore.Text = $"{form.scoreDraw}";
                DisableButtons(form);
                await AutoReset(form);
            }
        }

        private async Task AutoReset(TicTacToeForm form)
        {
            await Task.Delay(2000); // Wait for 2 seconds so players can see the result
            form.ResetScene();
        }

        public int CheckWinner()
        {
            int[,] winningCombinations = new int[,]
            {
                { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, // Rows
                { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, // Columns
                { 0, 4, 8 }, { 2, 4, 6 }  // Diagonals
            };

            for (int i = 0; i < 8; i++)
            {
                int a = winningCombinations[i, 0];
                int b = winningCombinations[i, 1];
                int c = winningCombinations[i, 2];

                if (Grid[a] == Grid[b] && Grid[a] == Grid[c] && Grid[a] != -1)
                {
                    return Grid[a]; // Return 1 for X, 0 for O
                }
            }

            return -1; // No winner yet
        }

        public void ResetGame()
        {
            turn = 0;
            Grid = new int[9]; // Reset array
            for (int i = 0; i < 9; i++)
            {
                Grid[i] = -1; // -1 means empty, 1 means X, 0 means O
            }
        }

        private void DisableButtons(TicTacToeForm form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is Button btn && btn.Name.StartsWith("BoxGrid"))
                {
                    btn.Enabled = false;
                }
            }
        }
    }
}
