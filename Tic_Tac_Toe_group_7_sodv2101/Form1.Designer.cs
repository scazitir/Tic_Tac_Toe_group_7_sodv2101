namespace Tic_Tac_Toe_group_7_sodv2101
{
    partial class Form1
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
            panel1 = new Panel();
            button9 = new Button();
            button6 = new Button();
            button3 = new Button();
            button8 = new Button();
            button5 = new Button();
            button2 = new Button();
            button7 = new Button();
            button4 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            playerOScore = new Label();
            playerXScore = new Label();
            label3 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            exitBtn = new Button();
            resetBtn = new Button();
            newGameBtn = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(25, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(474, 552);
            panel1.TabIndex = 0;
            // 
            // button9
            // 
            button9.Location = new Point(328, 383);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.Size = new Size(143, 167);
            button9.TabIndex = 0;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button6
            // 
            button6.Location = new Point(328, 191);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(143, 167);
            button6.TabIndex = 0;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button3
            // 
            button3.Location = new Point(328, 4);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(143, 167);
            button3.TabIndex = 0;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button8
            // 
            button8.Location = new Point(167, 383);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(143, 167);
            button8.TabIndex = 0;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button5
            // 
            button5.Location = new Point(167, 191);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(143, 167);
            button5.TabIndex = 0;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button2
            // 
            button2.Location = new Point(167, 4);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(143, 167);
            button2.TabIndex = 0;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button7
            // 
            button7.Location = new Point(3, 383);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(143, 167);
            button7.TabIndex = 0;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button4
            // 
            button4.Location = new Point(3, 191);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(143, 167);
            button4.TabIndex = 0;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(3, 4);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(143, 167);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(playerOScore);
            panel2.Controls.Add(playerXScore);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(542, 223);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(358, 345);
            panel2.TabIndex = 0;
            // 
            // playerOScore
            // 
            playerOScore.AutoSize = true;
            playerOScore.Font = new Font("Segoe UI", 28F);
            playerOScore.Location = new Point(233, 200);
            playerOScore.Name = "playerOScore";
            playerOScore.Size = new Size(52, 62);
            playerOScore.TabIndex = 0;
            playerOScore.Text = "0";
            // 
            // playerXScore
            // 
            playerXScore.AutoSize = true;
            playerXScore.Font = new Font("Segoe UI", 28F);
            playerXScore.Location = new Point(233, 61);
            playerXScore.Name = "playerXScore";
            playerXScore.Size = new Size(52, 62);
            playerXScore.TabIndex = 0;
            playerXScore.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 25F);
            label3.Location = new Point(32, 200);
            label3.Name = "label3";
            label3.Size = new Size(181, 57);
            label3.TabIndex = 0;
            label3.Text = "Player O";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(32, 61);
            label1.Name = "label1";
            label1.Size = new Size(174, 57);
            label1.TabIndex = 0;
            label1.Text = "Player X";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(exitBtn);
            panel3.Controls.Add(resetBtn);
            panel3.Controls.Add(newGameBtn);
            panel3.Location = new Point(542, 16);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(358, 173);
            panel3.TabIndex = 0;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(233, 51);
            exitBtn.Margin = new Padding(3, 4, 3, 4);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(99, 72);
            exitBtn.TabIndex = 0;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // resetBtn
            // 
            resetBtn.Location = new Point(127, 51);
            resetBtn.Margin = new Padding(3, 4, 3, 4);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(99, 72);
            resetBtn.TabIndex = 0;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // newGameBtn
            // 
            newGameBtn.Location = new Point(21, 51);
            newGameBtn.Margin = new Padding(3, 4, 3, 4);
            newGameBtn.Name = "newGameBtn";
            newGameBtn.Size = new Size(99, 72);
            newGameBtn.TabIndex = 0;
            newGameBtn.Text = "New Game";
            newGameBtn.UseVisualStyleBackColor = true;
            newGameBtn.Click += newGameBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Super Tic Tac Toe";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Panel panel2;
        private Panel panel3;
        private Button button9;
        private Button button6;
        private Button button3;
        private Button button8;
        private Button button5;
        private Button button2;
        private Button button7;
        private Button button4;
        private Label playerOScore;
        private Label playerXScore;
        private Label label3;
        private Label label1;
        private Button exitBtn;
        private Button resetBtn;
        private Button newGameBtn;
    }
}
