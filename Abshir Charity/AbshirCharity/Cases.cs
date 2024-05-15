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
    public partial class Cases : UserControl
    {
        private string connectionString = "Data Source=MAHMOUDHATEM;Initial Catalog=Abshir;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
        public Cases()
        {
            InitializeComponent();
        }

        private void Cases_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Cases", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No data found in the Cases table.");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("General Error: " + ex.Message);
            }
        }

        private void caseid_TextChanged(object sender, EventArgs e)
        {

        }

        private void applicantname_TextChanged(object sender, EventArgs e)
        {

        }

        private void applicantinfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void casetype_TextChanged(object sender, EventArgs e)
        {

        }

        private void casedescip_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void status_TextChanged(object sender, EventArgs e)
        {

        }

        private void AssistanceProvided_TextChanged(object sender, EventArgs e)
        {

        }

        private void casecomment_TextChanged(object sender, EventArgs e)
        {

        }

        private void updatebutt_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // تعريف الاستعلام المستخدم للتحديث داخل الدالة
                string sqlUpdate = @"
        UPDATE Cases
        SET 
            ApplicantName = @ApplicantName,
            ApplicantContactInfo = @ApplicantContactInfo,
            CaseType = @CaseType,
            CaseDescription = @CaseDescription,
            Status = @Status,
            ApplicationDate = @ApplicationDate,
            AssistanceDate = @AssistanceDate,
            AssistanceProvided = @AssistanceProvided,
            Comments = @Comments
        WHERE CaseID = @CaseID;
        ";

                using (SqlCommand cmd = new SqlCommand(sqlUpdate, conn))
                {
                    // تعيين القيم للمعاملات
                    cmd.Parameters.AddWithValue("@CaseID", caseid.Text);
                    cmd.Parameters.AddWithValue("@ApplicantName", applicantname.Text);
                    cmd.Parameters.AddWithValue("@ApplicantContactInfo", applicantinfo.Text);
                    cmd.Parameters.AddWithValue("@CaseType", casetype.Text);
                    cmd.Parameters.AddWithValue("@CaseDescription", casedescip.Text);
                    cmd.Parameters.AddWithValue("@Status", status.Text);
                    cmd.Parameters.AddWithValue("@ApplicationDate", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@AssistanceDate", dateTimePicker2.Value);
                    cmd.Parameters.AddWithValue("@AssistanceProvided", AssistanceProvided.Text);
                    cmd.Parameters.AddWithValue("@Comments", casecomment.Text);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Data updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Update failed.");
                    }
                }
            }

        }

        private void deletebutt_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(caseid.Text))
            {
                MessageBox.Show("Please provide a CaseID for deletion.");
                return;
            }

            // Confirmation dialog for deleting the case record
            DialogResult result = MessageBox.Show("Are you sure you want to delete this case record?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string connectionString = "Data Source=MAHMOUDHATEM;Initial Catalog=Abshir;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;"; // Replace with your SQL Server connection string

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Cases WHERE CaseID = @CaseID";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CaseID", caseid.Text); // Assuming you have a TextBox named 'caseid'

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

        private void savebutt_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // الاستعلام المحدث ليشمل جميع الأعمدة
                string sql = @"
                INSERT INTO Cases (
                CaseID, ApplicantName, ApplicantContactInfo, CaseType, CaseDescription,
                Status, ApplicationDate, AssistanceDate, AssistanceProvided, Comments
            ) VALUES (@CaseID,
                @ApplicantName, @ApplicantContactInfo, @CaseType, @CaseDescription,
                @Status, @ApplicationDate, @AssistanceDate, @AssistanceProvided, @Comments 
            );";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    // تحديث البيانات بناءً على الأعمدة الجديدة
                    cmd.Parameters.AddWithValue("@CaseID", caseid.Text);
                    cmd.Parameters.AddWithValue("@ApplicantName", applicantname.Text);
                    cmd.Parameters.AddWithValue("@ApplicantContactInfo", applicantinfo.Text);
                    cmd.Parameters.AddWithValue("@CaseType", casetype.Text);
                    cmd.Parameters.AddWithValue("@CaseDescription", casedescip.Text);
                    cmd.Parameters.AddWithValue("@Status", status.Text);
                    cmd.Parameters.AddWithValue("@ApplicationDate", dateTimePicker1.Value); // تأكد من تطابق الأسماء ونوع الكنترول
                    cmd.Parameters.AddWithValue("@AssistanceDate", dateTimePicker2.Value);
                    cmd.Parameters.AddWithValue("@AssistanceProvided", AssistanceProvided.Text);
                    cmd.Parameters.AddWithValue("@Comments", casecomment.Text);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Data saved successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Save failed.");
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
