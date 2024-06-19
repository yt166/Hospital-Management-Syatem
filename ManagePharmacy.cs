using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMSystem
{
    public partial class ManagePharmacy : Form
    {
        public ManagePharmacy()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            ManageAppointments manageAppointments = new ManageAppointments();
            manageAppointments.Show();
        }

        private void btnMedicalStaff_Click(object sender, EventArgs e)
        {
            ManageStaff manageStaff = new ManageStaff();
            manageStaff.Show();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            ManagePaymentscs managePaymentscs = new ManagePaymentscs();
            managePaymentscs.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();

        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            ManagePatient massagePatient = new ManagePatient();
            massagePatient.Show();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
