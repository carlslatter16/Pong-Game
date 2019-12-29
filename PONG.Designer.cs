namespace Pong_Game
{
    partial class FrmGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGame));
            this.PicPlayer01 = new System.Windows.Forms.PictureBox();
            this.PicPlayer02 = new System.Windows.Forms.PictureBox();
            this.tmrPaddleMove = new System.Windows.Forms.Timer(this.components);
            this.lblScore02 = new System.Windows.Forms.Label();
            this.lblScore01 = new System.Windows.Forms.Label();
            this.tmrBall = new System.Windows.Forms.Timer(this.components);
            this.PicBall = new System.Windows.Forms.PictureBox();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.PicSlow = new System.Windows.Forms.PictureBox();
            this.PicReverse = new System.Windows.Forms.PictureBox();
            this.picGrow = new System.Windows.Forms.PictureBox();
            this.PicCrack = new System.Windows.Forms.PictureBox();
            this.tmrpowerups = new System.Windows.Forms.Timer(this.components);
            this.PicBlackCrack = new System.Windows.Forms.PictureBox();
            this.tmrGrow01 = new System.Windows.Forms.Timer(this.components);
            this.tmrSlow = new System.Windows.Forms.Timer(this.components);
            this.tmrCrack = new System.Windows.Forms.Timer(this.components);
            this.tmrReverse01 = new System.Windows.Forms.Timer(this.components);
            this.tmrGrow02 = new System.Windows.Forms.Timer(this.components);
            this.tmrReverse02 = new System.Windows.Forms.Timer(this.components);
            this.picBarrier01 = new System.Windows.Forms.PictureBox();
            this.PicBarrier02 = new System.Windows.Forms.PictureBox();
            this.tmrBarriers = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PicPlayer01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPlayer02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicReverse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBlackCrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBarrier01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBarrier02)).BeginInit();
            this.SuspendLayout();
            // 
            // PicPlayer01
            // 
            this.PicPlayer01.BackColor = System.Drawing.Color.Transparent;
            this.PicPlayer01.Image = ((System.Drawing.Image)(resources.GetObject("PicPlayer01.Image")));
            this.PicPlayer01.Location = new System.Drawing.Point(12, 135);
            this.PicPlayer01.Name = "PicPlayer01";
            this.PicPlayer01.Size = new System.Drawing.Size(22, 72);
            this.PicPlayer01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicPlayer01.TabIndex = 0;
            this.PicPlayer01.TabStop = false;
            // 
            // PicPlayer02
            // 
            this.PicPlayer02.BackColor = System.Drawing.Color.Transparent;
            this.PicPlayer02.Image = ((System.Drawing.Image)(resources.GetObject("PicPlayer02.Image")));
            this.PicPlayer02.Location = new System.Drawing.Point(647, 135);
            this.PicPlayer02.Name = "PicPlayer02";
            this.PicPlayer02.Size = new System.Drawing.Size(22, 72);
            this.PicPlayer02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicPlayer02.TabIndex = 1;
            this.PicPlayer02.TabStop = false;
            // 
            // tmrPaddleMove
            // 
            this.tmrPaddleMove.Enabled = true;
            this.tmrPaddleMove.Interval = 5;
            this.tmrPaddleMove.Tick += new System.EventHandler(this.tmrPaddleMove_Tick);
            // 
            // lblScore02
            // 
            this.lblScore02.AutoSize = true;
            this.lblScore02.BackColor = System.Drawing.Color.Transparent;
            this.lblScore02.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore02.ForeColor = System.Drawing.Color.White;
            this.lblScore02.Location = new System.Drawing.Point(375, 9);
            this.lblScore02.Name = "lblScore02";
            this.lblScore02.Size = new System.Drawing.Size(32, 33);
            this.lblScore02.TabIndex = 3;
            this.lblScore02.Text = "0";
            // 
            // lblScore01
            // 
            this.lblScore01.AutoSize = true;
            this.lblScore01.BackColor = System.Drawing.Color.Transparent;
            this.lblScore01.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore01.ForeColor = System.Drawing.Color.White;
            this.lblScore01.Location = new System.Drawing.Point(292, 9);
            this.lblScore01.Name = "lblScore01";
            this.lblScore01.Size = new System.Drawing.Size(32, 33);
            this.lblScore01.TabIndex = 4;
            this.lblScore01.Text = "0";
            // 
            // tmrBall
            // 
            this.tmrBall.Interval = 1;
            this.tmrBall.Tick += new System.EventHandler(this.tmrBall_Tick);
            // 
            // PicBall
            // 
            this.PicBall.BackColor = System.Drawing.Color.Transparent;
            this.PicBall.Image = ((System.Drawing.Image)(resources.GetObject("PicBall.Image")));
            this.PicBall.Location = new System.Drawing.Point(334, 161);
            this.PicBall.Name = "PicBall";
            this.PicBall.Size = new System.Drawing.Size(31, 31);
            this.PicBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBall.TabIndex = 2;
            this.PicBall.TabStop = false;
            // 
            // tmrTime
            // 
            this.tmrTime.Interval = 1000;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Transparent;
            this.lblTime.Location = new System.Drawing.Point(590, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(52, 29);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "300";
            // 
            // PicSlow
            // 
            this.PicSlow.BackColor = System.Drawing.Color.Transparent;
            this.PicSlow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PicSlow.BackgroundImage")));
            this.PicSlow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PicSlow.Location = new System.Drawing.Point(323, 66);
            this.PicSlow.Name = "PicSlow";
            this.PicSlow.Size = new System.Drawing.Size(54, 50);
            this.PicSlow.TabIndex = 6;
            this.PicSlow.TabStop = false;
            this.PicSlow.Visible = false;
            // 
            // PicReverse
            // 
            this.PicReverse.BackColor = System.Drawing.Color.Transparent;
            this.PicReverse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PicReverse.BackgroundImage")));
            this.PicReverse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PicReverse.Location = new System.Drawing.Point(588, 31);
            this.PicReverse.Name = "PicReverse";
            this.PicReverse.Size = new System.Drawing.Size(54, 50);
            this.PicReverse.TabIndex = 7;
            this.PicReverse.TabStop = false;
            this.PicReverse.Visible = false;
            // 
            // picGrow
            // 
            this.picGrow.BackColor = System.Drawing.Color.Transparent;
            this.picGrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picGrow.BackgroundImage")));
            this.picGrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picGrow.Location = new System.Drawing.Point(325, 239);
            this.picGrow.Name = "picGrow";
            this.picGrow.Size = new System.Drawing.Size(52, 50);
            this.picGrow.TabIndex = 8;
            this.picGrow.TabStop = false;
            this.picGrow.Visible = false;
            // 
            // PicCrack
            // 
            this.PicCrack.BackColor = System.Drawing.Color.Transparent;
            this.PicCrack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PicCrack.BackgroundImage")));
            this.PicCrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PicCrack.Location = new System.Drawing.Point(35, 259);
            this.PicCrack.Name = "PicCrack";
            this.PicCrack.Size = new System.Drawing.Size(51, 50);
            this.PicCrack.TabIndex = 9;
            this.PicCrack.TabStop = false;
            this.PicCrack.Visible = false;
            // 
            // tmrpowerups
            // 
            this.tmrpowerups.Tick += new System.EventHandler(this.tmrpowerups_Tick);
            // 
            // PicBlackCrack
            // 
            this.PicBlackCrack.BackColor = System.Drawing.Color.Transparent;
            this.PicBlackCrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PicBlackCrack.Image = ((System.Drawing.Image)(resources.GetObject("PicBlackCrack.Image")));
            this.PicBlackCrack.Location = new System.Drawing.Point(496, 77);
            this.PicBlackCrack.Name = "PicBlackCrack";
            this.PicBlackCrack.Size = new System.Drawing.Size(29, 39);
            this.PicBlackCrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBlackCrack.TabIndex = 10;
            this.PicBlackCrack.TabStop = false;
            this.PicBlackCrack.Visible = false;
            // 
            // tmrGrow01
            // 
            this.tmrGrow01.Tick += new System.EventHandler(this.tmrGrow01_Tick);
            // 
            // tmrSlow
            // 
            this.tmrSlow.Tick += new System.EventHandler(this.tmrSlow_Tick);
            // 
            // tmrCrack
            // 
            this.tmrCrack.Tick += new System.EventHandler(this.tmrCrack_Tick);
            // 
            // tmrReverse01
            // 
            this.tmrReverse01.Tick += new System.EventHandler(this.tmrReverse01_Tick);
            // 
            // tmrGrow02
            // 
            this.tmrGrow02.Tick += new System.EventHandler(this.tmrGrow02_Tick);
            // 
            // tmrReverse02
            // 
            this.tmrReverse02.Tick += new System.EventHandler(this.tmrReverse02_Tick);
            // 
            // picBarrier01
            // 
            this.picBarrier01.BackColor = System.Drawing.Color.Maroon;
            this.picBarrier01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBarrier01.Location = new System.Drawing.Point(338, 0);
            this.picBarrier01.Name = "picBarrier01";
            this.picBarrier01.Size = new System.Drawing.Size(20, 60);
            this.picBarrier01.TabIndex = 11;
            this.picBarrier01.TabStop = false;
            this.picBarrier01.Visible = false;
            // 
            // PicBarrier02
            // 
            this.PicBarrier02.BackColor = System.Drawing.Color.Maroon;
            this.PicBarrier02.Location = new System.Drawing.Point(338, 318);
            this.PicBarrier02.Name = "PicBarrier02";
            this.PicBarrier02.Size = new System.Drawing.Size(20, 60);
            this.PicBarrier02.TabIndex = 12;
            this.PicBarrier02.TabStop = false;
            this.PicBarrier02.Visible = false;
            this.PicBarrier02.WaitOnLoad = true;
            // 
            // tmrBarriers
            // 
            this.tmrBarriers.Interval = 75;
            this.tmrBarriers.Tick += new System.EventHandler(this.tmrBarriers_Tick);
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(683, 378);
            this.Controls.Add(this.PicBarrier02);
            this.Controls.Add(this.picBarrier01);
            this.Controls.Add(this.PicBlackCrack);
            this.Controls.Add(this.PicCrack);
            this.Controls.Add(this.picGrow);
            this.Controls.Add(this.PicReverse);
            this.Controls.Add(this.PicSlow);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblScore01);
            this.Controls.Add(this.lblScore02);
            this.Controls.Add(this.PicBall);
            this.Controls.Add(this.PicPlayer02);
            this.Controls.Add(this.PicPlayer01);
            this.Name = "FrmGame";
            this.Text = "Pong";
            this.Load += new System.EventHandler(this.FrmGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmGame_KeyUp);
            this.Move += new System.EventHandler(this.FrmGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicPlayer01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPlayer02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSlow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicReverse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBlackCrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBarrier01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBarrier02)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicPlayer01;
        private System.Windows.Forms.PictureBox PicPlayer02;
        private System.Windows.Forms.Timer tmrPaddleMove;
        private System.Windows.Forms.Label lblScore02;
        private System.Windows.Forms.Label lblScore01;
        private System.Windows.Forms.Timer tmrBall;
        private System.Windows.Forms.PictureBox PicBall;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox PicSlow;
        private System.Windows.Forms.PictureBox PicReverse;
        private System.Windows.Forms.PictureBox picGrow;
        private System.Windows.Forms.PictureBox PicCrack;
        private System.Windows.Forms.Timer tmrpowerups;
        private System.Windows.Forms.PictureBox PicBlackCrack;
        private System.Windows.Forms.Timer tmrGrow01;
        private System.Windows.Forms.Timer tmrSlow;
        private System.Windows.Forms.Timer tmrCrack;
        private System.Windows.Forms.Timer tmrReverse01;
        private System.Windows.Forms.Timer tmrGrow02;
        private System.Windows.Forms.Timer tmrReverse02;
        private System.Windows.Forms.PictureBox picBarrier01;
        private System.Windows.Forms.PictureBox PicBarrier02;
        private System.Windows.Forms.Timer tmrBarriers;
    }
}

