using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock__paper__error_game
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        private void RestartIsClicked(object sender, EventArgs e)
        {

        }

        private void NoRestartIsClicked(object sender, EventArgs e)
        {

        }

        private void ErrorIsClicked(object sender, EventArgs e)
        {

        }

        private void PaperIsClicked(object sender, EventArgs e)
        {

        }

        private void RockIsClicked(object sender, EventArgs e)
        {

        }

        private void StartIsClicked(object sender, EventArgs e)
        {
            Start.Hide();
            StartQuestion.Hide();
            hidestart.Hide();
        }
    }
}
