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

namespace HMSystem
{
    public partial class PatientDashboard : Form
    {
        private String patientId;

        public void setPatientID(String patientId)
        {
            this.patientId = patientId;
        }

        public PatientDashboard()
        {
            InitializeComponent();
            LoadDoctorNames();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=hospitalmanagementsystemdb;Integrated Security=True");

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

                cmbDoctor.DataSource = doctorNames;
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

        public void SetPatientData(string patientId)
        {
            try
            {
                setPatientID(patientId);
                id.Text = patientId;
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Patient WHERE patient_id = @patient_id", conn);
                cmd.Parameters.AddWithValue("@patient_id", patientId);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtFirstName.Text = reader["fname"].ToString();
                    txtLName.Text = reader["lname"].ToString();
                    txtdob.Text = reader["dob"].ToString();
                    txtEmail.Text = reader["email"].ToString();
                    txtAddress.Text = reader["address"].ToString();
                    txtContact.Text = reader["contact"].ToString();
                    // Add other fields as necessary
                }
                else
                {
                    MessageBox.Show("Patient not found.");
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
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Patient SET fname = @fname, lname = @lname, dob = @dob, email = @email, address = @address, contact = @contact WHERE patient_id = @patient_id", conn);
                cmd.Parameters.AddWithValue("@patient_id", patientId);
                cmd.Parameters.AddWithValue("@fname", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@lname", txtLName.Text);
                cmd.Parameters.AddWithValue("@dob", txtdob.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@contact", txtContact.Text);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Patient data updated successfully.");
                }
                else
                {
                    MessageBox.Show("Update failed. Patient not found.");
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

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string newAppointmentId = GenerateNewAppointmentId(conn);

                // Get the selected doctor's ID
                string selectedDoctorName = cmbDoctor.SelectedItem.ToString();
                SqlCommand getDoctorIdCmd = new SqlCommand("SELECT staff_Id FROM Medical_Staff WHERE name = @name", conn);
                getDoctorIdCmd.Parameters.AddWithValue("@name", selectedDoctorName);
                string doctorId = (string)getDoctorIdCmd.ExecuteScalar();

                // Insert the appointment details
                SqlCommand insertCmd = new SqlCommand("INSERT INTO appointments (app_id, patient_id, staff_id, dateTime, status) VALUES (@app_id , @patient_id, @staff_id, @dateTime, @status)", conn);
                insertCmd.Parameters.AddWithValue("@app_id", newAppointmentId);
                insertCmd.Parameters.AddWithValue("@patient_id", "P00001");
                insertCmd.Parameters.AddWithValue("@staff_id", doctorId);

                insertCmd.Parameters.AddWithValue("@status", txtStatus.Text);


                if (DateTime.TryParse(appointmentsDate.Text, out DateTime appointmentDate))
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

        private string GenerateNewAppointmentId(SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 app_id FROM appointments ORDER BY app_id DESC", conn);
            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                string lastContactPersonId = result.ToString();
                int lastIdNumber = int.Parse(lastContactPersonId.Substring(1));
                int newIdNumber = lastIdNumber + 1;
                return "C" + newIdNumber.ToString("D5");
            }
            else
            {
                // If no records found, start with C0001
                return "C00001";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }

}
