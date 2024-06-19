using System.Data.SqlClient;

namespace HMSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmdUserRole.Items.Add("Admin");
            cmdUserRole.Items.Add("Patient");
            cmdUserRole.Items.Add("Doctor");
            cmdUserRole.Items.Add("Medical Staff");
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=hospitalmanagementsystemdb;Integrated Security=True");

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String userName = txtUserName.Text;
            String pw = txtPassword.Text;
            String user = cmdUserRole.SelectedItem.ToString();

            if (userName != null && pw != null)
            {
                this.Hide();

                if (user == "Admin")
                {
                    AdminDashboard adminDashboard = new AdminDashboard();
                    adminDashboard.Show();
                }
                else if (user == "Doctor")
                {
                    DoctorDashboard doctorDashboard = new DoctorDashboard();
                    String docid = GetDoctorIdByUsername(userName);
                    doctorDashboard.setDocId(docid);
                    doctorDashboard.Show();

                }
                else if (user == "Patient")
                {
                    PatientDashboard patientDashboard = new PatientDashboard();
                    String pid = GetPatientIdByUsername(userName);
                    patientDashboard.SetPatientData(pid);
                    patientDashboard.Show();
                }
                else if (user == "Medical Staff")
                {

                }
            }
            else
            {
                MessageBox.Show("Please Enter Required Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private string GetPatientIdByUsername(string userName)
        {
            string patientId = null;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT patient_id FROM Patient WHERE fname = @fname", conn);
                cmd.Parameters.AddWithValue("@fname", userName);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    patientId = result.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return patientId;
        }

        private string GetDoctorIdByUsername(string userName)
        {
            string patientId = null;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT staff_Id FROM Medical_Staff WHERE name = @name", conn);
                cmd.Parameters.AddWithValue("@name", userName);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    patientId = result.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return patientId;
        }

        private void register_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegister formRegister = new FormRegister();
            formRegister.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdUserRole_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
}