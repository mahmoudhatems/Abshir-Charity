using Microsoft.Data.SqlClient;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.DataFormats;
namespace AbshirCharity
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da1, da2;
        DataSet ds = new DataSet();
        DataSet dss = new DataSet();

        private void button1_Click(object sender, EventArgs e)
        {

            string cons = "Data Source=MAHMOUDHATEM;Initial Catalog=Abshir;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

            conn = new SqlConnection(cons);

            try
            {
                conn.Open();
                MessageBox.Show("Connection opened successfully!");

                // Check username and password
                if (textBox2.Text == Properties.Settings.Default.username && textBox1.Text == Properties.Settings.Default.password)
                {
                    // Hide the current login form
                    this.Visible = false;

                    // Show the Home form if both username and password match
                    Home home = new Home();
                    home.Show();
                }
                else
                {
                    // Clear text boxes
                    textBox1.Clear();
                    textBox2.Clear();
                    MessageBox.Show("Error: Invalid Username and Password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }




            // Hide the form if both username and password match
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
