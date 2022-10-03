namespace Rock_Paper_Scissors
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btn_stone = new System.Windows.Forms.Button();
            this.btn_paper = new System.Windows.Forms.Button();
            this.btn_scissors = new System.Windows.Forms.Button();
            this.lbl_score = new System.Windows.Forms.Label();
            this.btn_rivalStone = new System.Windows.Forms.Button();
            this.btn_rivalPaper = new System.Windows.Forms.Button();
            this.btn_rivalScissors = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_rivalScore = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_stone
            // 
            this.btn_stone.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_stone.Location = new System.Drawing.Point(315, 324);
            this.btn_stone.Name = "btn_stone";
            this.btn_stone.Size = new System.Drawing.Size(249, 68);
            this.btn_stone.TabIndex = 0;
            this.btn_stone.Text = "Stone";
            this.btn_stone.UseVisualStyleBackColor = true;
            this.btn_stone.Click += new System.EventHandler(this.btn_stone_Click);
            // 
            // btn_paper
            // 
            this.btn_paper.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_paper.Location = new System.Drawing.Point(315, 398);
            this.btn_paper.Name = "btn_paper";
            this.btn_paper.Size = new System.Drawing.Size(249, 68);
            this.btn_paper.TabIndex = 1;
            this.btn_paper.Text = "Paper";
            this.btn_paper.UseVisualStyleBackColor = true;
            this.btn_paper.Click += new System.EventHandler(this.btn_paper_Click);
            // 
            // btn_scissors
            // 
            this.btn_scissors.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_scissors.Location = new System.Drawing.Point(315, 472);
            this.btn_scissors.Name = "btn_scissors";
            this.btn_scissors.Size = new System.Drawing.Size(249, 68);
            this.btn_scissors.TabIndex = 2;
            this.btn_scissors.Text = "Scissors";
            this.btn_scissors.UseVisualStyleBackColor = true;
            this.btn_scissors.Click += new System.EventHandler(this.btn_scissors_Click);
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_score.Location = new System.Drawing.Point(68, 398);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(143, 39);
            this.lbl_score.TabIndex = 1;
            this.lbl_score.Text = "Score: 0";
            // 
            // btn_rivalStone
            // 
            this.btn_rivalStone.Enabled = false;
            this.btn_rivalStone.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_rivalStone.Location = new System.Drawing.Point(315, 160);
            this.btn_rivalStone.Name = "btn_rivalStone";
            this.btn_rivalStone.Size = new System.Drawing.Size(249, 68);
            this.btn_rivalStone.TabIndex = 0;
            this.btn_rivalStone.Text = "Stone";
            this.btn_rivalStone.UseVisualStyleBackColor = true;
            // 
            // btn_rivalPaper
            // 
            this.btn_rivalPaper.Enabled = false;
            this.btn_rivalPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_rivalPaper.Location = new System.Drawing.Point(315, 86);
            this.btn_rivalPaper.Name = "btn_rivalPaper";
            this.btn_rivalPaper.Size = new System.Drawing.Size(249, 68);
            this.btn_rivalPaper.TabIndex = 0;
            this.btn_rivalPaper.Text = "Paper";
            this.btn_rivalPaper.UseVisualStyleBackColor = true;
            // 
            // btn_rivalScissors
            // 
            this.btn_rivalScissors.Enabled = false;
            this.btn_rivalScissors.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_rivalScissors.Location = new System.Drawing.Point(315, 12);
            this.btn_rivalScissors.Name = "btn_rivalScissors";
            this.btn_rivalScissors.Size = new System.Drawing.Size(249, 68);
            this.btn_rivalScissors.TabIndex = 0;
            this.btn_rivalScissors.Text = "Scissors";
            this.btn_rivalScissors.UseVisualStyleBackColor = true;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_status.Location = new System.Drawing.Point(387, 258);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(0, 39);
            this.lbl_status.TabIndex = 2;
            // 
            // lbl_rivalScore
            // 
            this.lbl_rivalScore.AutoSize = true;
            this.lbl_rivalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_rivalScore.Location = new System.Drawing.Point(68, 105);
            this.lbl_rivalScore.Name = "lbl_rivalScore";
            this.lbl_rivalScore.Size = new System.Drawing.Size(143, 39);
            this.lbl_rivalScore.TabIndex = 1;
            this.lbl_rivalScore.Text = "Score: 0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(889, 551);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_rivalScore);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.btn_rivalScissors);
            this.Controls.Add(this.btn_scissors);
            this.Controls.Add(this.btn_rivalPaper);
            this.Controls.Add(this.btn_paper);
            this.Controls.Add(this.btn_rivalStone);
            this.Controls.Add(this.btn_stone);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_stone;
        private System.Windows.Forms.Button btn_paper;
        private System.Windows.Forms.Button btn_scissors;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Button btn_rivalStone;
        private System.Windows.Forms.Button btn_rivalPaper;
        private System.Windows.Forms.Button btn_rivalScissors;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_rivalScore;
        private System.Windows.Forms.Timer timer1;
    }
}

