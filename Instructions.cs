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
    public partial class Instructions : Form
    {
        public Instructions()
        {
            InitializeComponent();
        }

        private void Instructions_KeyDown(object sender, KeyEventArgs e)
        {
            //If enter is pressed, it will hide this form and go back to the start menu
            if (e.KeyData == Keys.Enter)
            {
                this.Hide();
                Start_Menu Start_Menu = new Start_Menu();
                Start_Menu.Show();
            }
        }

        
    }
}
