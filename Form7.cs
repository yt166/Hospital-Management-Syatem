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
    public partial class FormManagePatients : Form
    {
        public FormManagePatients()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FormDashboardAdmin formDashboardAdmin = new FormDashboardAdmin();
            formDashboardAdmin.Show();
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            FormManageAppointments formManageAppointments = new FormManageAppointments();
            formManageAppointments.Show();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            FormManageStaff formManageStaff = new FormManageStaff();
            formManageStaff.Show();
        }
    }
}
