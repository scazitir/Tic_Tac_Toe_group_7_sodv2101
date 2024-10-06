namespace Tic_Tac_Toe_group_7_sodv2101
{
    public partial class Form1 : Form
    {

        bool playerTurnChecker = false;
        int pointsCounter;
        public Form1()
        {
            InitializeComponent();
        }

        public void CheckScore()
        {
            bool winnerFound = false;

            // Rows
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                HighLightButtons(button1, button2, button3);

                DisplayWinnerMessage("X");
                pointsCounter = int.Parse(playerXScore.Text);
                playerXScore.Text = Convert.ToString(pointsCounter + 1);
                SetEnableAsFalse();
                winnerFound = true;
            }

            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                HighLightButtons(button4, button5, button6);

                DisplayWinnerMessage("X");
                pointsCounter = int.Parse(playerXScore.Text);
                playerXScore.Text = Convert.ToString(pointsCounter + 1);
                SetEnableAsFalse();
                winnerFound = true;
            }

            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                HighLightButtons(button7, button8, button9);

                DisplayWinnerMessage("X");
                pointsCounter = int.Parse(playerXScore.Text);
                playerXScore.Text = Convert.ToString(pointsCounter + 1);
                SetEnableAsFalse();
                winnerFound = true;
            }

            // Columns
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                HighLightButtons(button1, button4, button7);

                DisplayWinnerMessage("X");
                pointsCounter = int.Parse(playerXScore.Text);
                playerXScore.Text = Convert.ToString(pointsCounter + 1);
                SetEnableAsFalse();
                winnerFound = true;
            }

            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                HighLightButtons(button2, button5, button8);

                DisplayWinnerMessage("X");
                pointsCounter = int.Parse(playerXScore.Text);
                playerXScore.Text = Convert.ToString(pointsCounter + 1);
                SetEnableAsFalse();
                winnerFound = true;
            }

            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                HighLightButtons(button3, button6, button9);

                DisplayWinnerMessage("X");
                pointsCounter = int.Parse(playerXScore.Text);
                playerXScore.Text = Convert.ToString(pointsCounter + 1);
                SetEnableAsFalse();
                winnerFound = true;
            }

            // Diagonals
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                HighLightButtons(button1, button5, button9);

                DisplayWinnerMessage("X");
                pointsCounter = int.Parse(playerXScore.Text);
                playerXScore.Text = Convert.ToString(pointsCounter + 1);
                SetEnableAsFalse();
                winnerFound = true;
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                HighLightButtons(button3, button5, button7);

                DisplayWinnerMessage("X");
                pointsCounter = int.Parse(playerXScore.Text);
                playerXScore.Text = Convert.ToString(pointsCounter + 1);
                SetEnableAsFalse();
                winnerFound = true;
            }

            // ==================================================
            // "O" Player

            //Rows
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                HighLightButtons(button1, button2, button3);

                DisplayWinnerMessage("O");
                pointsCounter = int.Parse(playerOScore.Text);
                playerOScore.Text = Convert.ToString(pointsCounter + 1);
                SetEnableAsFalse();
                winnerFound = true;
            }

            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                HighLightButtons(button4, button5, button6);

                DisplayWinnerMessage("O");
                pointsCounter = int.Parse(playerOScore.Text);
                playerOScore.Text = Convert.ToString(pointsCounter + 1);
                SetEnableAsFalse();
                winnerFound = true;
            }

            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                HighLightButtons(button7, button8, button9);

                DisplayWinnerMessage("O");
                pointsCounter = int.Parse(playerOScore.Text);
                playerOScore.Text = Convert.ToString(pointsCounter + 1);
                SetEnableAsFalse();
                winnerFound = true;
            }

            // Columns
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                HighLightButtons(button1, button4, button7);

                DisplayWinnerMessage("O");
                pointsCounter = int.Parse(playerOScore.Text);
                playerOScore.Text = Convert.ToString(pointsCounter + 1);
                SetEnableAsFalse();
                winnerFound = true;
            }

            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                HighLightButtons(button2, button5, button8);

                DisplayWinnerMessage("O");
                pointsCounter = int.Parse(playerOScore.Text);
                playerOScore.Text = Convert.ToString(pointsCounter + 1);
                SetEnableAsFalse();
                winnerFound = true;
            }

            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                HighLightButtons(button3, button6, button9);

                DisplayWinnerMessage("O");
                pointsCounter = int.Parse(playerOScore.Text);
                playerOScore.Text = Convert.ToString(pointsCounter + 1);
                SetEnableAsFalse();
                winnerFound = true;
            }

            // Diagonals
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                HighLightButtons(button1, button5, button9);

                DisplayWinnerMessage("O");
                pointsCounter = int.Parse(playerOScore.Text);
                playerOScore.Text = Convert.ToString(pointsCounter + 1);
                SetEnableAsFalse();
                winnerFound = true;
            }

            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                HighLightButtons(button3, button5, button7);

                DisplayWinnerMessage("O");
                pointsCounter = int.Parse(playerOScore.Text);
                playerOScore.Text = Convert.ToString(pointsCounter + 1);
                SetEnableAsFalse();
                winnerFound = true;
            }

            // Check for Draw result
            if (!winnerFound && AllButtonsFilled())
            {
                DisplayDrawMessage();
                SetEnableAsFalse();
            }

        }
        private void DisplayWinnerMessage(string player)
        {
            MessageBox.Show($"Player {player} is the winner!!!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DisplayDrawMessage()
        {
            MessageBox.Show($"It's a draw! No one wins this time.", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            HandleButtonClick(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HandleButtonClick(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HandleButtonClick(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HandleButtonClick(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HandleButtonClick(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            HandleButtonClick(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HandleButtonClick(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            HandleButtonClick(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            HandleButtonClick(button9);
        }

        private void HandleButtonClick(Button button)
        {
            if (playerTurnChecker == false)
            {
                button.Text = "X";
                playerTurnChecker = true;
            }
            else
            {
                button.Text = "O";
                playerTurnChecker = false;
            }

            CheckScore();
            button.Enabled = false;
        }

        private void SetEnableAsFalse()
        {
            foreach (Control control in panel1.Controls)
            {
                if (control is Button)
                {
                    control.Enabled = false;
                }
            }
        }

        private void SetEnableAsTrue()
        {
            foreach (Control control in panel1.Controls)
            {
                if (control is Button)
                {
                    control.Enabled = true;
                }
            }
        }

        private void HighLightButtons(Button b1, Button b2, Button b3)
        {
            b1.BackColor = Color.DarkSeaGreen;
            b2.BackColor = Color.DarkSeaGreen;
            b3.BackColor = Color.DarkSeaGreen;
        }

        private bool AllButtonsFilled()
        {
            return button1.Text != "" && button2.Text != "" && button3.Text != "" &&
                   button4.Text != "" && button5.Text != "" && button6.Text != "" &&
                   button7.Text != "" && button8.Text != "" && button9.Text != "";
        }

        private void EmptyButtons()
        {
            foreach (Control control in panel1.Controls)
            {
                if (control is Button)
                {
                    control.Text = "";
                }
            }
        }

        private void SetBackColorToOriginal()
        {
            foreach (Control control in panel1.Controls)
            {
                if (control is Button)
                {
                    control.BackColor = Color.WhiteSmoke;
                }
            }
        }

        private void newGameBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SetEnableAsTrue();
                EmptyButtons();
                playerXScore.Text = "0";
                playerOScore.Text = "0";
                SetBackColorToOriginal();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tic Tac Toe", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SetEnableAsTrue();
                EmptyButtons();
                newGameBtn.Enabled = true;
                SetBackColorToOriginal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tic Tac Toe", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult userExit;
                userExit = MessageBox.Show("Would you like to close the game?", "Tic Tac Toe", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (userExit == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tic Tac Toe", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
