using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MafiaGame
{
    public partial class Lobby : Form
    {
        Login startForm;
        string myConnString = ConfigurationManager.ConnectionStrings["MafiaGameWF.Properties.Settings.MafiaDBConnectionString"].ConnectionString;

        public Lobby()
        {
            InitializeComponent();
        }

        public Lobby(string user, string password, string region, Login form)
        {
            InitializeComponent();
            //Player human = new Player(user, password, "Red");
            lblRegion.Text = region;
            lblUser.Text = user;
            startForm = form;


            string query = "SELECT COUNT(UserName) FROM Users WHERE UserName=@username AND Password=@password;";

            //using (SqlConnection conn = new SqlConnection(myConnString))
            //{
            //    SqlCommand cmd = new SqlCommand(query, conn);
            //    cmd.Parameters.AddWithValue("@username", username);
            //    cmd.Parameters.AddWithValue("@password", password);
            //    conn.Open();

            //    result = (int)cmd.ExecuteScalar();
            //}

        }

        private void Lobby_FormClosed(object sender, FormClosedEventArgs e)
        {
            startForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            startForm.Show();
        }
    }
}
