using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong_Game
{
    public partial class Start_Menu : Form
    {
        public Start_Menu()
        {
            InitializeComponent();
            
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //If the play button is pressed, the pong form will appear.
            this.Hide();
            FrmGame Pong = new FrmGame();
            Pong.Show();

        }

        private void btnHighScores_Click(object sender, EventArgs e)
        {
            //If the highscore button is pressed, the highscore form will appear.
            this.Hide();
            High_Score High_Score = new High_Score();
            High_Score.Show();
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            //If the instructions button is pressed, the instructions form will appear.
            this.Hide();
            Instructions Instructions = new Instructions();
            Instructions.Show();
        }
    }
}
