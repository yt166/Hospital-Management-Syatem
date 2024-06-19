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
    public partial class DoctorDashboard : Form
    {
        private String docid;
        public DoctorDashboard()
        {
            InitializeComponent();
            DisplayAppointments();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=hospitalmanagementsystemdb;Integrated Security=True");

        public void setDocId(String docid)
        {
            this.docid = docid;


        }
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DisplayAppointments()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT app_id, patient_id, dateTime, status FROM appointments", conn);
                SqlDataAdapter sqlData = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlData.Fill(dt);
                doctorAppointments.DataSource = dt;

                DataGridViewButtonColumn colViewDetails = new DataGridViewButtonColumn();
                colViewDetails.HeaderText = "View Details";
                colViewDetails.Text = "View";
                colViewDetails.UseColumnTextForButtonValue = true;
                doctorAppointments.Columns.Add(colViewDetails);

                /*SqlCommand cmd2 = new SqlCommand("SELECT name FROM Medical_Staff WHERE staff_Id = @staff_Id", conn);
                cmd.Parameters.AddWithValue("@staff_Id", docid);
                SqlDataReader reader = cmd.ExecuteReader();
                name.Text = reader.GetString("Name");*/
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
