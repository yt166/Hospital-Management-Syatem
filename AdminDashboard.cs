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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagePatient managePatient = new ManagePatient();
            managePatient.ShowDialog();
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageAppointments manageAppointments = new ManageAppointments();
            manageAppointments.ShowDialog();
        }

        private void btnMedicalStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageStaff manageStaff = new ManageStaff();
            manageStaff.ShowDialog();
        }

        private void btnPharmacy_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagePharmacy managePharmacy = new ManagePharmacy();
            managePharmacy.ShowDialog();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagePaymentscs managePaymentscs = new ManagePaymentscs();
            managePaymentscs.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
