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

namespace AbshirCharity
{
    public partial class Monthly : UserControl
    {
        public Monthly()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Monthly_Load(object sender, EventArgs e)
        {
            LoadMonthlyData();
        }
        string connectionString = "Data Source=MAHMOUDHATEM;Initial Catalog=Abshir;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
        private void LoadMonthlyData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT AssistanceID, CaseID, AssistanceAmount, AssistanceType, DeliveryDate, Notes FROM MonthlyAssistances";

                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void savebutt_Click(object sender, EventArgs e)
        {

            try
            {
                string connectionString = "Data Source=MAHMOUDHATEM;Initial Catalog=Abshir;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO MonthlyAssistances (AssistanceID, CaseID, AssistanceAmount, AssistanceType, DeliveryDate, Notes) " +
                                   "VALUES (@AssistanceID, @CaseID, @AssistanceAmount, @AssistanceType, @DeliveryDate, @Notes)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@AssistanceID", assistanceid.Text);
                    command.Parameters.AddWithValue("@CaseID", caseid.Text);
                    command.Parameters.AddWithValue("@AssistanceAmount", AssistanceAmount.Text);
                    command.Parameters.AddWithValue("@AssistanceType", monthtype.Text);
                    command.Parameters.AddWithValue("@DeliveryDate", dateTimePicker1.Value);
                    command.Parameters.AddWithValue("@Notes", monthnotes.Text);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show(rowsAffected + " row(s) inserted.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void updatebutt_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(assistanceid.Text))
            {
                MessageBox.Show("Please provide an AssistanceID for updating.");
                return;
            }

            try
            {
                string connectionString = "Data Source=MAHMOUDHATEM;Initial Catalog=Abshir;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;"; // Replace with your SQL Server connection string
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE MonthlyAssistances SET CaseID = @CaseID, AssistanceAmount = @AssistanceAmount, AssistanceType = @AssistanceType, DeliveryDate = @DeliveryDate, Notes = @Notes WHERE AssistanceID = @AssistanceID";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@AssistanceID", assistanceid.Text);
                    command.Parameters.AddWithValue("@CaseID", caseid.Text);
                    command.Parameters.AddWithValue("@AssistanceAmount", AssistanceAmount.Text);
                    command.Parameters.AddWithValue("@AssistanceType", monthtype.Text);
                    command.Parameters.AddWithValue("@DeliveryDate", dateTimePicker1.Value);
                    command.Parameters.AddWithValue("@Notes", monthnotes.Text);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show(rowsAffected + " row(s) updated.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void deletebutt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(assistanceid.Text))
            {
                MessageBox.Show("Please provide an AssistanceID for deletion.");
                return;
            }

            // Confirmation dialog for deleting the assistance record
            DialogResult result = MessageBox.Show("Are you sure you want to delete this assistance record?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string connectionString = "Data Source=MAHMOUDHATEM;Initial Catalog=Abshir;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;"; // Replace with your SQL Server connection string

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM MonthlyAssistances WHERE AssistanceID = @AssistanceID";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@AssistanceID", assistanceid.Text); // Assuming you have a TextBox named 'assistanceid'

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show(rowsAffected + " row(s) deleted.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void assistanceid_TextChanged(object sender, EventArgs e)
        {

        }

        private void caseid_TextChanged(object sender, EventArgs e)
        {

        }

        private void AssistanceAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void monthtype_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthnotes_TextChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

    }
}
