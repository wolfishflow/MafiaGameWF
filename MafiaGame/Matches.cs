using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MafiaGame
{
    public partial class Matches : Form
    {
        Player human;
        Lobby form;

        public Matches()
        {
            InitializeComponent();
        }

        public Matches(Player player, Lobby previousForm,int matchId ,string matchName)
        {
            InitializeComponent();

            human = player;
            form = previousForm;

        }

        private void Matches_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Show();
        }
    }
}
