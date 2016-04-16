using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MafiaGame
{
    public partial class Login : Form
    {
        string myConnString = ConfigurationManager.ConnectionStrings["MafiaGameWF.Properties.Settings.MafiaDBConnectionString"].ConnectionString;

        public Login()
        {
            InitializeComponent();
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(tbPassword.Text))
            {
                if (CheckForUser())
                {
                    Lobby lobby = new Lobby(cbUserName.Text,            tbPassword.Text.Trim(), cbRegion.Text, this);
                    lobby.Show();
                    Hide();
                }
                else
                {
                    lblErrorMsg.Text = "Invalid Username/Password combination";
                    lblErrorMsg.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                lblErrorMsg.Text = "Password field cannot be blank or whitespace.";
                lblErrorMsg.ForeColor = System.Drawing.Color.Red;
            }
        }

        private bool CheckForUser()
        {
            string password = tbPassword.Text.Trim();
            string username = cbUserName.Text;
            string query = "SELECT COUNT(UserName) FROM Users WHERE UserName=@username AND Password=@password;";

            int result = 0;
            using (SqlConnection conn = new SqlConnection(myConnString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                conn.Open();

                result = (int)cmd.ExecuteScalar();
            }

            if (result > 0) return true;
            else return false;
        }

    }
}
