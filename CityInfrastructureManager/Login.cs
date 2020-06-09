using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityInfrastructureManager
{
    public partial class Login : Form
    {
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader sdr;
        public Login()
        {
            InitializeComponent();
            connection.ConnectionString = @"Server = 193.198.57.183; Database = PIS_TEST; User Id = student; Password = student";
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            connection.Open();
            command.Connection = connection;
            command.CommandText = "SELECT korisnicko_ime, lozinka FROM [03_Korisnik] WHERE korisnicko_ime ='" + textBoxUsername.Text + "' AND lozinka= '" + textBoxPassword.Text + "'";
            sdr = command.ExecuteReader();
            if (sdr.Read())
            {
                this.Hide();
                InfraastructureFailureManager infrastructureFailureManager = new InfraastructureFailureManager(this);
                //infrastructureFailureManager.Closed += (s, args) => this.Close();
                infrastructureFailureManager.Show();

            }
            else
            {
                MessageBox.Show("Korisničko ime ili lozinka su netočni", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = panel1;
        }

        private void txtUsernameEnter(object sender, EventArgs e)
        {
            if(textBoxUsername.Text == "Korisničko ime")
            {
                textBoxUsername.Text = "";
            }
        }

        private void txtUsernameLeave(object sender, EventArgs e)
        {
            if(textBoxUsername.Text == "")
            {
                textBoxUsername.Text = "Korisničko ime";
            }
        }

        private void txtPasswordEnter(object sender, EventArgs e)
        {
            if(textBoxPassword.Text == "Lozinka")
            {
                textBoxPassword.Text = "";
            }
        }

        private void txtPasswordLeave(object sender, EventArgs e)
        {
            if(textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "Lozinka";
            }
        }
        public string GetUsername
        {
            get { return textBoxUsername.Text; }
        }
    }
}
