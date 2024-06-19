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
    public partial class ManageStaff : Form
    {
        public ManageStaff()
        {
            InitializeComponent();
            DisplayStaff();
            cmbRole.Items.Add("Doctor");
            cmbRole.Items.Add("Nurse");
            cmbRole.Items.Add("Pharmacist");
            cmbRole.Items.Add("Lab-Assistant");

            viewStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=hospitalmanagementsystemdb;Integrated Security=True");

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

        private void btnPatients_Click(object sender, EventArgs e)
        {
            ManagePatient managePatient = new ManagePatient();
            managePatient.Show();
        }

        private string GenerateNewStaffId(SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 staff_Id FROM Medical_Staff ORDER BY staff_Id DESC", conn);
            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                string lastStaffId = result.ToString();
                int lastIdNumber = int.Parse(lastStaffId.Substring(1));
                int newIdNumber = lastIdNumber + 1;
                return "P" + newIdNumber.ToString("D5");
            }
            else
            {
                // If no records found, start with P0001
                return "P00001";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String staffName = txtName.Text;
            String s_mail = txtEmail.Text;
            String s_add = txtAddress.Text;
            String s_contact = txtContact.Text;
            String S_role = cmbRole.SelectedItem.ToString();
            String pw = s_contact;

            try
            {

                conn.Open();

                string newStaffId = GenerateNewStaffId(conn);


                // Insert first contact person
                SqlCommand cmd1 = new SqlCommand("INSERT INTO Medical_Staff (staff_Id, name, jobrole,address, contact, email , password) VALUES (@staff_Id, @name, @jobrole, @address, @contact, @email, @password)", conn);
                cmd1.Parameters.AddWithValue("@staff_Id", newStaffId);
                cmd1.Parameters.AddWithValue("@name", staffName);
                cmd1.Parameters.AddWithValue("@jobrole", S_role);
                cmd1.Parameters.AddWithValue("@address", s_add);
                cmd1.Parameters.AddWithValue("@contact", s_contact);
                cmd1.Parameters.AddWithValue("@email", s_mail);
                cmd1.Parameters.AddWithValue("@password", pw);

                cmd1.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("New Member Added Successful!");
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                conn.Close();
            }

            viewStaff.ClearSelection();
            DisplayStaff();
        }

        private void DisplayStaff()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT staff_Id, name AS 'Name', jobrole, address,contact, email FROM Medical_Staff", conn);
                SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlData.Fill(dt);
                viewStaff.DataSource = dt;

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

        private void btnBack_Click(object sender, EventArgs e)
        {
                this.Close();
                Form1 form1 = new Form1();
                form1.ShowDialog();
        }
    }
}
