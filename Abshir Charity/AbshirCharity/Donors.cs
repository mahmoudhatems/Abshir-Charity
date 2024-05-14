using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AbshirCharity
{
    public partial class Donors : UserControl
    {
        public Donors()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void savebutt_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=MAHMOUDHATEM;Initial Catalog=Abshir;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;"; // Replace with your SQL Server connection string

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Donors (FullName, City, State, Country, Phone, Email, DonationDate, DonationAmount, DonationType, DesignatedProject, Comments, Service) " +
                               "VALUES (@FullName, @City, @State, @Country, @Phone, @Email, @DonationDate, @DonationAmount, @DonationType, @DesignatedProject, @Comments, @Service)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FullName", fullname.Text);
                command.Parameters.AddWithValue("@City", city.Text);
                command.Parameters.AddWithValue("@State", state.Text); // Assuming you have a TextBox named 'state'
                command.Parameters.AddWithValue("@Country", state.Text); // Assuming you have a TextBox named 'contry' (perhaps 'country' is misspelled?)
                command.Parameters.AddWithValue("@Phone", country.Text);
                command.Parameters.AddWithValue("@Email", phone.Text);
                command.Parameters.AddWithValue("@DonationDate", dateTimePicker1.Value);
                command.Parameters.AddWithValue("@DonationAmount", decimal.Parse(Damount.Text));
                command.Parameters.AddWithValue("@DonationType", Dtype.Text);
                command.Parameters.AddWithValue("@DesignatedProject", Designated.Text);
                command.Parameters.AddWithValue("@Comments", comment.Text);
                command.Parameters.AddWithValue("@Service", service.Text);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show(rowsAffected + " row(s) inserted.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void donorid_TextChanged(object sender, EventArgs e)
        {

        }

        private void fullname_TextChanged(object sender, EventArgs e)
        {

        }

        private void city_TextChanged(object sender, EventArgs e)
        {

        }

        private void contry_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void Damount_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Dtype_TextChanged(object sender, EventArgs e)
        {

        }

        private void Designated_TextChanged(object sender, EventArgs e)
        {

        }

        private void comment_TextChanged(object sender, EventArgs e)
        {

        }

        private void service_TextChanged(object sender, EventArgs e)
        {

        }

        private void updatebutt_Click(object sender, EventArgs e)
        {

        }

        private void deletebutt_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Donors_Load(object sender, EventArgs e)
        {

        }
    }
}
