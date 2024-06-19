using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HMSystem
{
    public partial class ManagePatient : Form
    {
        public ManagePatient()
        {
            InitializeComponent();
            InitializeDataGridView();
            DisplayPatients();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=hospitalmanagementsystemdb;Integrated Security=True");

        private void InitializeDataGridView()
        {

            PatientData.CellContentClick += PatientData_CellContentClick;
        }

        private void PatientData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = PatientData.Rows[e.RowIndex];

                // Check if View Details button clicked
                if (PatientData.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex == PatientData.Columns["View Details"].Index)
                {
                    string patientId = row.Cells["Patient ID"].Value.ToString();
                    ViewPatientInfo viewPatient = new ViewPatientInfo();
                    viewPatient.Show();
                    // Implement logic to view more details about the patient using patientId
                    MessageBox.Show($"View details for Patient ID: {patientId}");
                    // Example: Open new form to show details
                    // FormPatientDetails patientDetailsForm = new FormPatientDetails(patientId);
                    // patientDetailsForm.ShowDialog();
                }
            }
        }


        private void DisplayPatients()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT patient_id, fname AS 'First Name', lname, contact, dob, email FROM Patient", conn);
                SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlData.Fill(dt);
                PatientData.DataSource = dt;

                DataGridViewButtonColumn colViewDetails = new DataGridViewButtonColumn();
                colViewDetails.HeaderText = "View Details";
                colViewDetails.Text = "View";
                colViewDetails.UseColumnTextForButtonValue = true;
                PatientData.Columns.Add(colViewDetails);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageAppointments manageAppointments = new ManageAppointments();
            manageAppointments.Show();
        }

        private void btnMedicalStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageStaff manageStaff = new ManageStaff();
            manageStaff.Show();
        }

        private void btnPharmacy_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagePharmacy managePharmacy = new ManagePharmacy();
            managePharmacy.Show();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagePaymentscs managePaymentscs = new ManagePaymentscs();
            managePaymentscs.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
