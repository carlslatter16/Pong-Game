namespace Pong_Game
{
    partial class Start_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start_Menu));
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.PicPong = new System.Windows.Forms.PictureBox();
            this.btnHighScores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicPong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.BackgroundImage")));
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPlay.ForeColor = System.Drawing.Color.Transparent;
            this.btnPlay.Location = new System.Drawing.Point(241, 138);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(220, 60);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnInstructions
            // 
            this.btnInstructions.BackColor = System.Drawing.Color.Transparent;
            this.btnInstructions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInstructions.BackgroundImage")));
            this.btnInstructions.Location = new System.Drawing.Point(241, 204);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(220, 63);
            this.btnInstructions.TabIndex = 2;
            this.btnInstructions.UseVisualStyleBackColor = false;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // PicPong
            // 
            this.PicPong.BackColor = System.Drawing.Color.Transparent;
            this.PicPong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PicPong.BackgroundImage")));
            this.PicPong.Location = new System.Drawing.Point(205, 12);
            this.PicPong.Name = "PicPong";
            this.PicPong.Size = new System.Drawing.Size(293, 103);
            this.PicPong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicPong.TabIndex = 3;
            this.PicPong.TabStop = false;
            // 
            // btnHighScores
            // 
            this.btnHighScores.BackColor = System.Drawing.Color.Transparent;
            this.btnHighScores.Image = ((System.Drawing.Image)(resources.GetObject("btnHighScores.Image")));
            this.btnHighScores.Location = new System.Drawing.Point(241, 273);
            this.btnHighScores.Name = "btnHighScores";
            this.btnHighScores.Size = new System.Drawing.Size(220, 61);
            this.btnHighScores.TabIndex = 0;
            this.btnHighScores.UseVisualStyleBackColor = false;
            this.btnHighScores.Click += new System.EventHandler(this.btnHighScores_Click);
            // 
            // Start_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(683, 378);
            this.Controls.Add(this.btnHighScores);
            this.Controls.Add(this.PicPong);
            this.Controls.Add(this.btnInstructions);
            this.Controls.Add(this.btnPlay);
            this.Name = "Start_Menu";
            this.Text = "Start_Menu";
            ((System.ComponentModel.ISupportInitialize)(this.PicPong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.PictureBox PicPong;
        private System.Windows.Forms.Button btnHighScores;
    }
}