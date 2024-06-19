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
using Org.BouncyCastle.Asn1.Cmp;

namespace HMSystem
{
    public partial class ManageAppointments : Form
    {
        public ManageAppointments()
        {
            InitializeComponent();
            LoadDoctorNames();
            DisplayAppointments();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=hospitalmanagementsystemdb;Integrated Security=True");

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagePatient managePatient = new ManagePatient();
            managePatient.Show();
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
            ManagePaymentscs payments = new ManagePaymentscs();
            payments.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void LoadDoctorNames()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT name FROM Medical_Staff", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                List<string> doctorNames = new List<string>();

                while (reader.Read())
                {
                    doctorNames.Add(reader["name"].ToString());
                }

                cmbDoctors.DataSource = doctorNames;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string newAppointmentId = GenerateNewAppointmentId(conn);

                // Get the selected doctor's ID
                string selectedDoctorName = cmbDoctors.SelectedItem.ToString();
                SqlCommand getDoctorIdCmd = new SqlCommand("SELECT staff_Id FROM Medical_Staff WHERE name = @name", conn);
                getDoctorIdCmd.Parameters.AddWithValue("@name", selectedDoctorName);
                string doctorId = (string)getDoctorIdCmd.ExecuteScalar();

                // Insert the appointment details
                SqlCommand insertCmd = new SqlCommand("INSERT INTO appointments (app_id, patient_id, staff_id, dateTime, status) VALUES (@app_id , @patient_id, @staff_id, @dateTime, @status)", conn);
                insertCmd.Parameters.AddWithValue("@app_id", newAppointmentId);
                insertCmd.Parameters.AddWithValue("@patient_id", txtPatient.Text);
                insertCmd.Parameters.AddWithValue("@staff_id", doctorId);

                insertCmd.Parameters.AddWithValue("@status", txtStatus.Text);

                if (DateTime.TryParse(appointmentdate.Text, out DateTime appointmentDate))
                {
                    insertCmd.Parameters.AddWithValue("@dateTime", appointmentDate);
                }
                else
                {
                    MessageBox.Show("Invalid Date time format");
                    return;
                }

                insertCmd.ExecuteNonQuery();

                MessageBox.Show("Appointment successfully created.");
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

        private void DisplayAppointments()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT app_id, patient_id, staff_id, dateTime, status FROM appointments", conn);
                SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlData.Fill(dt);
                allAppointments.DataSource = dt;

                DataGridViewButtonColumn colViewDetails = new DataGridViewButtonColumn();
                colViewDetails.HeaderText = "View Details";
                colViewDetails.Text = "View";
                colViewDetails.UseColumnTextForButtonValue = true;
                allAppointments.Columns.Add(colViewDetails);
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

        private string GenerateNewAppointmentId(SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 app_id FROM appointments ORDER BY app_id DESC", conn);
            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                string lastContactPersonId = result.ToString();
                int lastIdNumber = int.Parse(lastContactPersonId.Substring(1));
                int newIdNumber = lastIdNumber + 1;
                return "AP" + newIdNumber.ToString("D5");
            }
            else
            {
                // If no records found, start with C0001
                return "AP00001";
            }
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            }
        }
    }
}
