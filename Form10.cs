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
    public partial class FormDashboardAdmin : Form
    {
        public FormDashboardAdmin()
        {
            InitializeComponent();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            FormManagePatients formManagePatients = new FormManagePatients();
            formManagePatients.ShowDialog();
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            FormManageAppointments formManageAppointments = new FormManageAppointments();
            formManageAppointments.ShowDialog();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            FormManageStaff formManageStaff = new FormManageStaff();
            formManageStaff.ShowDialog();
        }
    }
}
