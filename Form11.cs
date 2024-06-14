using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class FormManageStaff : Form
    {
        public FormManageStaff()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FormDashboardAdmin formDashboardAdmin = new FormDashboardAdmin();
            formDashboardAdmin.Show();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            FormManagePatients formManagePatients = new FormManagePatients();
            formManagePatients.Show();
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            FormManageAppointments formManageAppointments = new FormManageAppointments();
            formManageAppointments.Show();
        }
    }
}
