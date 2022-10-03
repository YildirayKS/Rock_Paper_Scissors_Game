using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors
{
    public partial class Form1 : Form
    {
        int score, rivalScore = 0;
        public Form1()
        {
            InitializeComponent();

            Button_Color_Setter();
        }

        // Thanks to this method, the colors of the buttons that have changed color will be restored.
        public void Button_Color_Setter()
        {
            btn_stone.BackColor = Color.White;
            btn_paper.BackColor = Color.White;
            btn_scissors.BackColor = Color.White;

            btn_rivalStone.BackColor = Color.White;
            btn_rivalPaper.BackColor = Color.White;
            btn_rivalScissors.BackColor = Color.White;
        }

        private void btn_stone_Click(object sender, EventArgs e)
        {
            Button_Color_Setter();

            Random random = new Random();

            int value_4_stone = random.Next(1, 4); //1 is stone,2 is paper,3 is scissors 

            if (value_4_stone == 1)
            {
                lbl_status.Text = "DRAW!";
                btn_rivalStone.BackColor = Color.DarkGray;
            }
            else if (value_4_stone == 2)
            {
                lbl_status.Text = "LOSE!";
                lbl_rivalScore.Text = "Score: " + rivalScore++;
                btn_rivalPaper.BackColor = Color.Red;
            }
            else
            {
                lbl_status.Text = "WIN!";
                lbl_score.Text = "Score: " + score++;
                btn_rivalScissors.BackColor = Color.Green;
            }
        }

        private void btn_paper_Click(object sender, EventArgs e)
        {
            Button_Color_Setter();

            Random random = new Random();

            int value_4_paper = random.Next(1, 4); //1 is stone,2 is paper,3 is scissors 

            if (value_4_paper == 1)
            {
                lbl_status.Text = "WIN!";
                lbl_score.Text = "Score: " + score++;
                btn_rivalStone.BackColor = Color.Green;

            }
            else if (value_4_paper == 2)
            {
                lbl_status.Text = "DRAW!";
                btn_rivalPaper.BackColor = Color.DarkGray;

            }
            else
            {
                lbl_status.Text = "LOSE!";
                lbl_rivalScore.Text = "Score: " + rivalScore++;
                btn_rivalScissors.BackColor = Color.Red;
            }
        }

        private void btn_scissors_Click(object sender, EventArgs e)
        {
            Button_Color_Setter();

            Random random = new Random();

            int value_4_scissors = random.Next(1, 4); //1 is stone,2 is paper,3 is scissors 

            if (value_4_scissors == 1)
            {
                lbl_status.Text = "LOSE!";
                lbl_rivalScore.Text = "Score: " + rivalScore++;
                btn_rivalStone.BackColor = Color.Red;

            }
            else if (value_4_scissors == 2)
            {
                lbl_status.Text = "WIN!";
                lbl_score.Text = "Score: " + score++;
                btn_rivalPaper.BackColor = Color.Green;

            }
            else
            {
                lbl_status.Text = "DRAW!";
                btn_rivalScissors.BackColor = Color.DarkGray;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (score == 11) //The reason we put 11 here is to show the score 10.
            {
                lbl_status.Text = "You Won!";

                btn_stone.Enabled = false;
                btn_paper.Enabled = false;
                btn_scissors.Enabled = false;
                btn_rivalStone.Enabled = false;
                btn_rivalPaper.Enabled = false;
                btn_rivalScissors.Enabled = false;
            }
            else if (rivalScore == 11) //The reason we put 11 here is to show the score 10.
            {
                lbl_status.Text = "Rival Won!";

                btn_stone.Enabled = false;
                btn_paper.Enabled = false;
                btn_scissors.Enabled = false;
                btn_rivalStone.Enabled = false;
                btn_rivalPaper.Enabled = false;
                btn_rivalScissors.Enabled = false;
            }
        }

    }
}
