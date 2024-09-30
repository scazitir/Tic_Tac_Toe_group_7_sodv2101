namespace Tic_Tac_Toe_group_7_sodv2101
{
    public partial class Form1 : Form
    {

        bool playerTurnChecker = false;
        public Form1()
        {
            InitializeComponent();
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

        public void HandleButtonClick(Button button)
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

            // Implement CheckScore()
            button.Enabled = false;
        }
    }
}
