using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using Microsoft.VisualBasic;


namespace Pong_Game
{
    public partial class FrmGame : Form
    {

        //These are the variables I am going to use later, this includes bool,int,strings and other variables.

        //These are for the paddle movement.
        bool Player01Up, Player01Down, Player02Up, Player02Down;

        //This controls the movement of the ball.
        int movementofballx = 4;
        int movementofbally = -4;
        int X = 8;
        int Y = -8;

        //This is used to store the time.
        int Time = 300;

        //Used for Random Number Generator later with array.
        Random Rnd = new Random();

        //This is used to store the random angle.
        int AngleX = 0;

        //These are the scores for the players and act as a way to store them.
        int score01 = 0;
        int score02 = 0;

        //These are used for storing the random variables for the increase of the score
        int ScoreX = 5;
        int ScoreY = 5;
        int ScoreZ = 5;
        int ScoreCaluclation1 = 0;
        int ScoreCaluclation2 = 0;

        //These are variables used to compare the winning score against the current high score.
        int WinningScore;
        int Highscore;

        //This is to set up who touched the ball last and is useful for powerups and the ball movement against the barrier on either side.
        bool BallRed = false;
        bool BallBlue = false;


        //These are variables that changes depending on if the grow powerup is collected and stop the paddles either moving out the form or from there being random barriers.
        int paddle01Stop = 305;
        int paddle02Stop = 305;

        //These are the timers that count down from 30 seconds(100 interval) and allow the effects to wear off for either player.
        int Powerupgrow01timer = 300;
        int Powerupgrow02timer = 300;
        int Powerupslowtimer = 300;
        int Powerupcracktimer = 300;
        int powerupreverse01timer = 300;
        int powerupreverse02timer = 300;

        //These are variables for if the player is reversed.
        bool ReversedPlayer01 = false;
        bool ReversedPlayer02 = false;

        //These are variables for if the relevant powerup is collected, and by who.
        bool Reverse01Collected = false;
        bool Reverse02Collected = false;
        bool SlowCollected = false;
        bool CrackCollected = false;
        bool Grow01Collected = false;
        bool Grow02Collected = false;

        //These variables are for moving the barriers up and down automatically on their own.
        bool BarrierMoveDown01;
        bool BarrierMoveDown02;
        bool BarrierMoveUp01;
        bool BarrierMoveUp02;

        //This is to test if the highscore is beaten.
        bool HighScoreBeaten;

        //This is to check if the game has started.
        bool GameStarted;

        //These are to control if the barriers are actually visible.
        bool Barrier01Visible = false;
        bool Barrier02Visible = false;

        //These are to give a name that can be reconised by c# to the files that are referenced.
        string HighscoreNumberFile = "HighScoreNumber.txt";
        string HighscoreNameFile = "HighScoreName.txt";

        //This Variable is for referencing the input box I have if the highscore is beaten for the name.
        string Inputted_Name;

        //This sets up the array for the powerups.
        PictureBox[] Powerups = new PictureBox[4];
        //This sets up the array for the score increments.
        int[] ScoreIncrements = new int[3];

        public FrmGame()
        {
            InitializeComponent();

        }

        private void FrmGame_Load(object sender, EventArgs e)
        {



            //this stops the flickering effect on the form.
            DoubleBuffered = true;

            //This loads the array of the powerups and assigns each picture box with a number.
            Powerups[0] = picGrow;
            Powerups[1] = PicSlow;
            Powerups[2] = PicCrack;
            Powerups[3] = PicReverse;

            //This loads the array of the score increments and assigns each with a number.
            ScoreIncrements[0] = 0;
            ScoreIncrements[1] = 5;
            ScoreIncrements[2] = 10;
        }


        private void FrmGame_KeyDown(object sender, KeyEventArgs e)
        {
            //This is to start the game and various timers, as well as set the gamestarted to be true.
            if (e.KeyData == Keys.Space)
            {
                tmrpowerups.Start();
                tmrBall.Start();
                tmrTime.Start();
                tmrBarriers.Start();
                GameStarted = true;
                tmrPaddleMove.Start();

            }

            //These keys are for movement of paddels when the keys are pressed.
            if (e.KeyData == Keys.W && ReversedPlayer01 == false)
            {
                Player01Up = true;
            }

            if (e.KeyData == Keys.S && ReversedPlayer01 == false)
            {
                Player01Down = true;
            }

            if (e.KeyData == Keys.Up && ReversedPlayer02 == false)
            {
                Player02Up = true;
            }

            if (e.KeyData == Keys.Down && ReversedPlayer02 == false)
            {
                Player02Down = true;
            }



            //These keys are for movement of paddels when the keys are pressed.
            if (e.KeyData == Keys.W && ReversedPlayer01 == true)
            {
                Player01Down = true;
            }

            if (e.KeyData == Keys.S && ReversedPlayer01 == true)
            {
                Player01Up = true;
            }

            if (e.KeyData == Keys.Up && ReversedPlayer02 == true)
            {
                Player02Down = true;
            }

            if (e.KeyData == Keys.Down && ReversedPlayer02 == true)
            {
                Player02Up = true;
            }

            if (e.KeyData == Keys.Escape)
            {
                tmrpowerups.Stop();
                tmrBall.Stop();
                tmrTime.Stop();
                tmrBarriers.Stop();
                tmrPaddleMove.Stop();
            }
        }


        private void FrmGame_KeyUp(object sender, KeyEventArgs e)
        {
            //These keys are for movement of paddels when the keys are not pressed.

            if (e.KeyData == Keys.W && ReversedPlayer01 == false)
            {
                Player01Up = false;
            }

            if (e.KeyData == Keys.S && ReversedPlayer01 == false)
            {
                Player01Down = false;
            }

            if (e.KeyData == Keys.Up && ReversedPlayer02 == false)
            {
                Player02Up = false;
            }

            if (e.KeyData == Keys.Down && ReversedPlayer02 == false)
            {
                Player02Down = false;
            }


            if (e.KeyData == Keys.W && ReversedPlayer01 == true)
            {
                Player01Down = false;
            }

            if (e.KeyData == Keys.S && ReversedPlayer01 == true)
            {
                Player01Up = false;
            }

            if (e.KeyData == Keys.Up && ReversedPlayer02 == true)
            {
                Player02Down = false;
            }

            if (e.KeyData == Keys.Down && ReversedPlayer02 == true)
            {
                Player02Up = false;
            }

        }

        private void tmrBall_Tick(object sender, EventArgs e)
        {
            //This is to adjust the angle and the direction for movement of the ball if it hits different places, like paddles and the top/bottom of the form. It also changes whos ball it is, when it intersects.

            PicBall.Left += movementofballx + AngleX;
            PicBall.Top += movementofbally;

            if (PicBall.Top <= 0)
            {
                AngleX = Rnd.Next(2, 3);
                movementofbally = X;
            }

            if (PicBall.Top >= 346)
            {
                AngleX = Rnd.Next(1, 2);
                movementofbally = Y;
            }

            if (PicBall.Bounds.IntersectsWith(PicPlayer02.Bounds))
            {
                movementofballx = Y - AngleX;
                BallRed = false;
                BallBlue = true;
            }

            if (PicBall.Bounds.IntersectsWith(PicPlayer01.Bounds))
            {
                movementofballx = X - AngleX;
                BallRed = true;
                BallBlue = false;

            }

            //This is to get the ball to start off fast at usually, at a smaller angle.
            if (GameStarted == true)
            {
                if (Time == 300)
                {
                    PicBall.Left += movementofballx;
                }
            }



            //This is to enable player 1 to score and to reposition the player.

            if (PicBall.Left >= 660)
            {
                PicBall.Left = 331;
                PicBall.Top = 161;
                
                //This specific code is to implement calculations and random score increments for added difficulty.

                score01 = score01 + ScoreZ;
                ScoreX = Rnd.Next(0, 2);
                ScoreY = Rnd.Next(0, 2);
                ScoreZ = (ScoreCaluclation1 + ScoreCaluclation2) + 5;
                ScoreCaluclation1 = ScoreIncrements[ScoreX];
                ScoreCaluclation2 = ScoreIncrements[ScoreY];



            }

            //This is to enable player 2 to score and to reposition the player.

            if (PicBall.Left <= -25)
            {
                PicBall.Left = 331;
                PicBall.Top = 161;

                //This specific code is to implement calculations and random score increments for added difficulty.

                score02 = score02 + ScoreZ;
                ScoreX = Rnd.Next(0, 2);
                ScoreY = Rnd.Next(0, 2);
                ScoreZ = (ScoreCaluclation1 + ScoreCaluclation2) + 5;
                ScoreCaluclation1 = ScoreIncrements[ScoreX];
                ScoreCaluclation2 = ScoreIncrements[ScoreY];

            }

            //This displays the int scores in the labels of both.

            lblScore01.Text = score01.ToString();
            lblScore02.Text = score02.ToString();
        }


        private void tmrTime_Tick(object sender, EventArgs e)
        {


            //This takes 1 from the timer per second and then displays it in the label.

            int ShowTime = Time--;
            lblTime.Text = ShowTime.ToString();


            //This ends the game after 5 minutes and counts scores and declares a winner.

            if (Time == -1)
            {
                GameStarted = false;
                tmrBall.Stop();
                this.Hide();
                Start_Menu Start_Menu = new Start_Menu();
                Start_Menu.Show();
                if (score01 > score02)
                {
                    lblTime.Hide();
                    MessageBox.Show("Player 1 Wins!");
                    WinningScore = score01;

                }

                if (score01 < score02)
                {
                    lblTime.Hide();
                    MessageBox.Show("Player 2 Wins!");
                    WinningScore = score02;
                }

                if (score01 == score02)
                {
                    lblTime.Hide();
                    MessageBox.Show("The game is a draw!");
                    WinningScore = score01 & score02;
                }

                //This sets up the file for the streamreader. 
                HighScoreRead(HighscoreNumberFile);

                //This is to change the variable if the score is higher than that in the highscore database.
                if (WinningScore > Highscore)
                {
                    HighScoreBeaten = true;

                    HighScoreNumWrite(HighscoreNumberFile);
                    HighscoreNameWrite(HighscoreNameFile);
                }
                else
                {
                    HighScoreBeaten = false;
                }
            }

            //This makes the first barrier appear at 200 seconds.
            if (Time <= 200)
            {
                Barrier01Visible = true;
            }

            //This makes the first barrier appear at 200 seconds.
            if (Time <= 100)
            {
                Barrier02Visible = true;
            }
        }

        void HighScoreRead(string path)
        {
            //This reads the database and inserts the data into a variable that can then be compared.
            StreamReader Read = new StreamReader(path);
            string Line = Read.ReadLine();

            Highscore = int.Parse(Line);

            Read.Close();
        }

        void HighScoreNumWrite(string path)
        {
            //This is to insert the score into the database,replacing what is already there if the data is smaller than the score.
            StreamWriter WriteNum = new StreamWriter(path);
            if (HighScoreBeaten == true)
            {


                if (File.Exists(path) == true)
                {
                    WriteNum.Write(WinningScore);

                    WriteNum.Flush();
                    WriteNum.Close();
                }
            }

            if (HighScoreBeaten == false)
            {
                WriteNum.Close();

            }
        }

        void HighscoreNameWrite(string path)
        {
            //This lets you write in your name in an input box if the high score has been beaten which goes into a database.
            StreamWriter WriteName = new StreamWriter(path);
            if (HighScoreBeaten == true)
            {
                Inputted_Name = Interaction.InputBox("Congratulations! The Winner/s of the game have beaten the High Score! Enter your name for it do be displayed on the High Score Screen.", "New High Score");


                if (File.Exists(path) == true)
                {
                    WriteName.Write(Inputted_Name);
                    WriteName.Flush();
                    WriteName.Close();
                }
            }
        }

        private void tmrpowerups_Tick(object sender, EventArgs e)
        {
            //This selects a random time for a powerup to appear and a random type to appear.
            int poweruprandomtime = Rnd.Next(0, 300);
            int poweruprandomtype = Rnd.Next(0, 4);

            if (Time == poweruprandomtime)
            {
                //This inputs the random type and decides where it should spawn.
                Powerups[poweruprandomtype].Show();
                int randomtoplocation = Rnd.Next(31, 416);
                int randomleftlocation = Rnd.Next(35, 588);
                Powerups[poweruprandomtype].Top = randomtoplocation;
                Powerups[poweruprandomtype].Left = randomleftlocation;
            }

            //These are timers that subtract each second until it reaches 0 if collected.
            if (CrackCollected == true)
            {
                Powerupcracktimer--;
            }

            if (SlowCollected == true)
            {
                Powerupslowtimer--;
            }

            if (Grow01Collected)
            {
                Powerupgrow01timer--;
            }

            if (Grow02Collected)
            {
                Powerupgrow02timer--;
            }

            if (Reverse01Collected)
            {
                powerupreverse01timer--;
            }

            if (Reverse02Collected)
            {
                powerupreverse02timer--;
            }


            //This increases the size of the paddle for either player 1 or 2 if the powerup is hit
            if (PicBall.Bounds.IntersectsWith(picGrow.Bounds) && BallRed == true && picGrow.Visible)
            {
                PicPlayer01.Size = new Size(22, 115);
                paddle01Stop = 275;
                picGrow.Hide();

                Grow01Collected = true;
                tmrGrow01.Start();
            }

            if (PicBall.Bounds.IntersectsWith(picGrow.Bounds) && BallBlue == true && picGrow.Visible)
            {
                PicPlayer02.Size = new Size(22, 115);
                paddle02Stop = 275;
                picGrow.Hide();
                Grow02Collected = true;
                tmrGrow02.Start();
            }

            //This slows down the interval for the ball if the powerup is hit which slows everything about the ball down.
            if (PicBall.Bounds.IntersectsWith(PicSlow.Bounds) && PicSlow.Visible)
            {
                tmrBall.Interval = 50;
                PicSlow.Hide();

                SlowCollected = true;
                tmrSlow.Start();
            }

            //This moves the crack,increases the size and makes it visible for 30 seconds
            if (PicBall.Bounds.IntersectsWith(PicCrack.Bounds) && PicCrack.Visible)
            {
                PicBlackCrack.Show();
                PicCrack.Hide();
                PicBlackCrack.BringToFront();
                PicBlackCrack.Size = new Size(297, 553);
                PicBlackCrack.Left = 200;
                PicBlackCrack.Top = -107;

                CrackCollected = true;
                tmrCrack.Start();
            }

            //This code is for the reverse powerup for each player and sets various varibles to true, I needed these variables because reassigning the controls is complex to control otherwise.
            if (PicBall.Bounds.IntersectsWith(PicReverse.Bounds) && PicReverse.Visible && BallRed)
            {
                PicReverse.Hide();

                ReversedPlayer01 = true;
                Reverse01Collected = true;
                tmrReverse01.Start();
            }

            if (PicBall.Bounds.IntersectsWith(PicReverse.Bounds) && PicReverse.Visible && BallBlue)
            {
                PicReverse.Hide();

                Reverse02Collected = true;
                ReversedPlayer02 = true;
                tmrReverse02.Start();
            }

        }

        private void tmrGrow01_Tick(object sender, EventArgs e)
        {
            //These 2 pieces of code control what happens if their timers hit 0, in this case, it resizes it and puts the bounds back to normal.
            if (Powerupgrow01timer == 0)
            {
                PicPlayer01.Size = new Size(22, 72);
                paddle01Stop = 305;
                Grow01Collected = false;
            }
        }

        private void tmrGrow02_Tick(object sender, EventArgs e)
        {
            if (Powerupgrow02timer == 0)
            {
                PicPlayer02.Size = new Size(22, 72);
                paddle02Stop = 305;
                Grow02Collected = false;
            }
        }

        private void tmrSlow_Tick(object sender, EventArgs e)
        {
            //If the slow timer hits 0, it will reset the interval of tmrball back to 1.
            if (Powerupslowtimer == 0)
            {
                Powerupslowtimer = 300;
                tmrBall.Interval = 1;

                SlowCollected = false;
            }
        }

        private void tmrCrack_Tick(object sender, EventArgs e)
        {
            //If the crack timer hits 0, the crack image will be hidden.
            if (Powerupcracktimer == 0)
            {
                Powerupcracktimer = 300;
                PicBlackCrack.Hide();

                CrackCollected = false;
            }
        }

        private void tmrReverse01_Tick(object sender, EventArgs e)
        {
            //These 2 pieces of code will make the variables that make the reversal effect back to false.
            if (powerupreverse01timer == 0)
            {
                powerupreverse01timer = 300;

                Reverse01Collected = false;
                if (ReversedPlayer01 = true && powerupreverse01timer == 0)
                {
                    Reverse01Collected = false;
                    ReversedPlayer01 = false;
                }
            }
        }

        private void tmrReverse02_Tick(object sender, EventArgs e)
        {

            if (powerupreverse02timer == 0)
            {
                powerupreverse02timer = 300;

                Reverse02Collected = false;

                if (ReversedPlayer02 = true && powerupreverse02timer == 0)
                {
                    ReversedPlayer02 = false;
                    Reverse01Collected = false;
                }
            }
        }

        private void tmrBarriers_Tick(object sender, EventArgs e)
        {
            //This will move the barriers up and down if the varibles have been set to true.
            if (GameStarted == true && picBarrier01.Visible)
            {
                if (BarrierMoveDown01 == true)
                {
                    picBarrier01.Top = picBarrier01.Top + 5;
                }

                if (BarrierMoveUp01 == true)
                {
                    picBarrier01.Top = picBarrier01.Top - 5;
                }

                if (picBarrier01.Top == 0)
                {
                    //If the barrier hits the top, it will set the up varibles to false and down to true, to change direction.
                    BarrierMoveDown01 = true;
                    BarrierMoveUp01 = false;

                }

                if (picBarrier01.Top >= 318)
                {
                    //If the barrier hits the bottom, it will set the up varibles to true and down to false, to change direction.
                    BarrierMoveUp01 = true;
                    BarrierMoveDown01 = false;

                }

                if (GameStarted == true && PicBarrier02.Visible)
                {
                    //All this does the same as the above code but for the second barrier.
                    if (BarrierMoveDown02 == true)
                    {
                        PicBarrier02.Top = PicBarrier02.Top + 5;
                    }

                    if (BarrierMoveUp02 == true)
                    {
                        PicBarrier02.Top = PicBarrier02.Top - 5;
                    }

                    if (PicBarrier02.Top <= 0)
                    {
                        BarrierMoveDown02 = true;
                        BarrierMoveUp02 = false;

                    }

                    if (PicBarrier02.Top >= 318)
                    {
                        BarrierMoveUp02 = true;
                        BarrierMoveDown02 = false;

                    }

                }

                if (picBarrier01.Bounds.IntersectsWith(PicBall.Bounds) && BallRed == true && picBarrier01.Visible)
                {
                    //This means that if the barrier is visible, hits the ball and player 1 hit it last, the ball will go left.
                    movementofballx = -5;
                }

                if (picBarrier01.Bounds.IntersectsWith(PicBall.Bounds) && BallBlue == true && picBarrier01.Visible)
                {
                    //This means that if the barrier is visible, hits the ball and player 2 hit it last, the ball will go right.
                    movementofballx = 5;
                }

                if (PicBarrier02.Bounds.IntersectsWith(PicBall.Bounds) && BallRed == true && PicBarrier02.Visible)
                {
                    //This does the same as the above code but for player 2 instead of 1
                    movementofballx = -5;
                }

                if (PicBarrier02.Bounds.IntersectsWith(PicBall.Bounds) && BallBlue == true && PicBarrier02.Visible)
                {
                    movementofballx = 5;
                }
            }



            if (Barrier01Visible == true)
            {
                //This is to make the first barrier visible.
                picBarrier01.Visible = true;

            }

            if (Barrier02Visible == true)
            {
                //This is to make the second barrier visible.
                PicBarrier02.Visible = true;
            }
        }



        public void CheckIfMoving()                      //If player press the key to move the paddle, this method
        {
            //This sets up certain bounds for the paddles
            int Speed01 = 5;
            int Speed02 = 5;
            int Speed03 = 5;
            int Speed04 = 5;
            if (PicPlayer01.Top == 0)
            {
                Speed01 = 0;
            }
            if (PicPlayer02.Top == 0)
            {
                Speed02 = 0;
            }
            if (PicPlayer01.Top == paddle01Stop)
            {

                Speed03 = 0;
            }
            if (PicPlayer02.Top == paddle02Stop)
            {
                Speed04 = 0;
            }



            //changes the Y position of the paddle if conditions are met
            if (Player01Up == true)
                PicPlayer01.Top -= Speed01;
            if (Player01Down == true)
                PicPlayer01.Top += Speed03;
            if (Player02Up == true)
                PicPlayer02.Top -= Speed02;
            if (Player02Down == true)
                PicPlayer02.Top += Speed04;
        }
        private void tmrPaddleMove_Tick(object sender, EventArgs e)
        {
            //This constantly checks if the paddels are moving
            CheckIfMoving();
        }


        protected override CreateParams CreateParams
        {
            //stops flicering during animation
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }


    }
}
