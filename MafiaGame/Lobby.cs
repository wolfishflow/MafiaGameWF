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
    public partial class Lobby : Form
    {
        Login startForm;
        string myConnString = ConfigurationManager.ConnectionStrings["MafiaGameWF.Properties.Settings.MafiaDBConnectionString"].ConnectionString;
        string query;

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
            populateMatches(region);

        }
        
        private void btnLogout_Click(object sender, EventArgs e)
        {
            startForm.Show();
        }

        private void Lobby_FormClosed(object sender, FormClosedEventArgs e)
        {
            startForm.Show();
        }

        private void Lobby_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mafiaDBDataSet.Matches' table. You can move, or remove it, as needed.
            this.matchesTableAdapter.Fill(this.mafiaDBDataSet.Matches);

        }


        private void populateMatches(string region)
        {
            int regionID = 0;
            switch(region)
            {
                case "East":
                    regionID = 4;
                    break;
                case "West":
                    regionID = 3;
                    break;
                case "North":
                    regionID = 1;
                    break;
                case "South":
                    regionID = 2;
                    break;
            }

            query = "SELECT [MatchName], [MatchId] FROM Matches WHERE RegionID=@regionID;";

            using (SqlConnection conn = new SqlConnection(myConnString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@regionID", regionID);
                conn.Open();
                SqlDataAdapter dap = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                dap.Fill(data);

                lbMatches.DisplayMember = "MatchName";
                lbMatches.DataSource = data;
            }

        }
    }
}
