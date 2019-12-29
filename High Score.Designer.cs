namespace Pong_Game
{
    partial class High_Score
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(High_Score));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblHighScoreName = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(76, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(153, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HIGH SCORE";
            // 
            // lblHighScoreName
            // 
            this.lblHighScoreName.AutoSize = true;
            this.lblHighScoreName.BackColor = System.Drawing.Color.Transparent;
            this.lblHighScoreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScoreName.ForeColor = System.Drawing.Color.White;
            this.lblHighScoreName.Location = new System.Drawing.Point(40, 73);
            this.lblHighScoreName.Name = "lblHighScoreName";
            this.lblHighScoreName.Size = new System.Drawing.Size(72, 25);
            this.lblHighScoreName.TabIndex = 6;
            this.lblHighScoreName.Text = "Empty";
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.BackColor = System.Drawing.Color.Transparent;
            this.lblHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore.Location = new System.Drawing.Point(223, 73);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(25, 25);
            this.lblHighScore.TabIndex = 11;
            this.lblHighScore.Text = "0";
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Location = new System.Drawing.Point(42, 119);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(187, 13);
            this.lblExit.TabIndex = 16;
            this.lblExit.Text = "Press \'Enter\' to go back to Main Menu";
            // 
            // High_Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(309, 154);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.lblHighScoreName);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "High_Score";
            this.Text = "The High Score";
            
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.High_Scores_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblHighScoreName;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Label lblExit;
    }
}