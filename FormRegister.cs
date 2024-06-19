using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using Mysqlx.Crud;

namespace HMSystem
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=hospitalmanagementsystemdb;Integrated Security=True");



        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            String pfName = txtFirstName.Text;
            String plName = txtLastName.Text;
            String dob = txtDOB.Text;
            String email = txtEmail.Text;
            String contact = txtContact.Text;
            String sex = txtGender.Text;
            String address = txtAddress.Text;
            String password = textBox9.Text;
            String contactPerson1fn = textBox1.Text;
            String contactPerson1ln = textBox2.Text;
            String p1contact = textBox3.Text;
            String p1relation = textBox4.Text;
            String contactPerson2fn = textBox5.Text;
            String contactPerson2ln = textBox6.Text;
            String p2contact = textBox7.Text;
            String p2relation = textBox8.Text;

            try
            {
                /*conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO ContactPerson values(fname, lname, contact, relation) OUTPUT INSERTED.contact_person_id VALUES(@fname, @lname, @contact, @relationship)", conn);
                cmd.ExecuteNonQuery();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO Patients values(fname, lname, dob, address, contact, email, password, contact_person) VALUES (@fname, @lname, @dob, @address, @contact, @email, @password, @contact_person1, @contact_person2)", conn);
                sqlCommand.ExecuteNonQuery();
                conn.Close();*/


                conn.Open();

                string newPatientId = GenerateNewPatientId(conn);
                string newContactPerson1Id = GenerateNewContactPersonId(conn);


                // Insert first contact person
                SqlCommand cmd1 = new SqlCommand("INSERT INTO ContactPerson (contact_person_id, fname, lname, contact, relationship) VALUES (@contact_person_id, @fname, @lname, @contact, @relationship)", conn);
                cmd1.Parameters.AddWithValue("@contact_person_id", newContactPerson1Id);
                cmd1.Parameters.AddWithValue("@fname", contactPerson1fn);
                cmd1.Parameters.AddWithValue("@lname", contactPerson1ln);
                cmd1.Parameters.AddWithValue("@contact", p1contact);
                cmd1.Parameters.AddWithValue("@relationship", p1relation);

                cmd1.ExecuteNonQuery();

                // Insert second contact person
                string newContactPerson2Id = GenerateNewContactPersonId(conn);

                SqlCommand cmd2 = new SqlCommand("INSERT INTO ContactPerson (contact_person_id, fname, lname, contact, relationship) VALUES (@contact_person_id, @fname, @lname, @contact, @relationship)", conn);
                cmd2.Parameters.AddWithValue("@contact_person_id", newContactPerson2Id);
                cmd2.Parameters.AddWithValue("@fname", contactPerson2fn);
                cmd2.Parameters.AddWithValue("@lname", contactPerson2ln);
                cmd2.Parameters.AddWithValue("@contact", p2contact);
                cmd2.Parameters.AddWithValue("@relationship", p2relation);

                cmd2.ExecuteNonQuery();

                // Insert patient
                SqlCommand cmd3 = new SqlCommand("INSERT INTO Patient (patient_id, fname, lname, dob, address, contact, email, password, contact_person1, contact_person2) VALUES (@patient_id, @fname, @lname, @dob, @address, @contact, @email, @password, @contact_person1, @contact_person2)", conn);
                cmd3.Parameters.AddWithValue("@patient_id", newPatientId);
                cmd3.Parameters.AddWithValue("@fname", pfName);
                cmd3.Parameters.AddWithValue("@lname", plName);
                cmd3.Parameters.AddWithValue("@dob", dob);
                cmd3.Parameters.AddWithValue("@address", address);
                cmd3.Parameters.AddWithValue("@contact", contact);
                cmd3.Parameters.AddWithValue("@email", email);
                cmd3.Parameters.AddWithValue("@password", password);
                cmd3.Parameters.AddWithValue("@contact_person1", newContactPerson1Id);
                cmd3.Parameters.AddWithValue("@contact_person2", newContactPerson2Id);

                cmd3.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Registration Successful!");
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                conn.Close();
            }

        }

        private string GenerateNewPatientId(SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 patient_id FROM Patient ORDER BY patient_id DESC", conn);
            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                string lastPatientId = result.ToString();
                int lastIdNumber = int.Parse(lastPatientId.Substring(1));
                int newIdNumber = lastIdNumber + 1;
                return "P" + newIdNumber.ToString("D5");
            }
            else
            {
                // If no records found, start with P0001
                return "P00001";
            }
        }

        private string GenerateNewContactPersonId(SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 contact_person_id FROM ContactPerson ORDER BY contact_person_id DESC", conn);
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
