﻿using System;
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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void lblRegistration_Click(object sender, EventArgs e)
        {

        }

        private void lblPatientInformation_Click(object sender, EventArgs e)
        {

        }

        private void txtFIrstName_Validating(object sender, CancelEventArgs e)
        {
            string patientFirstName = txtFirstName.Text;

        }
    }
}
