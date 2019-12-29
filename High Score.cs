using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pong_Game
{
    public partial class High_Score : Form
    {
        //This links the files to actual c# names.
        string HighscoreNumberFile = "HighScoreNumber.txt";
        string HighscoreNameFile = "HighScoreName.txt";
        
        //This is the variable for the highscore name.
        string PlayerName;

        //This is the variable for the high score number.
        int Highscore;

        public High_Score()
        {
            InitializeComponent();

            //This sets up the routines for the Stream Readers used below
            HighScoreNumRead(HighscoreNumberFile);
            HighScoreNameRead(HighscoreNameFile);
        }

        void HighScoreNumRead(string path)
        {
            //This reads the number in the database and converts it to an interger that c# displays in the label.
            StreamReader NumRead = new StreamReader(path);
            string Line = NumRead.ReadLine();
            Highscore = int.Parse(Line);
            lblHighScore.Text = Highscore.ToString();
            lblHighScore.Refresh();
            lblHighScoreName.Refresh();
            NumRead.Close();
        }

        void HighScoreNameRead (string path)
        {
            //This reads the string in the database and displays it in the label.
            StreamReader NameRead = new StreamReader(path);
            string NameLine = NameRead.ReadLine();
            PlayerName = NameLine;
            lblHighScoreName.Text = PlayerName;
            lblHighScoreName.Refresh();
            lblHighScore.Refresh();
            NameRead.Close();
        }

        private void High_Scores_KeyDown(object sender, KeyEventArgs e)
        {
            //This sends you back to the start menu if the enter key is pressed.
            if (e.KeyData == Keys.Enter)
            {
                this.Hide();
                Start_Menu Start_Menu = new Start_Menu();
                Start_Menu.Show();
            }
        }

       
    }


   
}
