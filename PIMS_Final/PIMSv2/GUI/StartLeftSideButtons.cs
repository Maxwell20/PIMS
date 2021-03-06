﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIMS
{
    public partial class StartLeftSideButtons : UserControl
    {
        // Default Constructor
        public StartLeftSideButtons()
        {
            InitializeComponent();
        }

        // Will allow the user to serach for a new patient
        private void newSearchButton_Click(object sender, EventArgs e)
        {
            Program.currentPatient = null;

            // Clear contents of Panel1 and Panel2
            Program.myForm.splitContainer1.Panel1.Controls.Clear();
            Program.myForm.splitContainer1.Panel2.Controls.Clear();

            // Add LoginLeftSideButtons to Panel1
            Program.myForm.splitContainer1.Panel1.Controls.Add(new LoginLeftSideButtons());
            // Add PatientSearch to Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Add(new PatientSearch());
        }

        // Will log the current user off of the server
        private void logOffButton_Click(object sender, EventArgs e)
        {
            Program.currentPatient = null;
            Program.currentUser = null;

            Program.myForm.label2.Text = "";

            // Clear contents of Panel1 and Panel2
            Program.myForm.splitContainer1.Panel1.Controls.Clear();
            Program.myForm.splitContainer1.Panel2.Controls.Clear();

            // Add LoginLeftSideButtons to Panel1
            Program.myForm.splitContainer1.Panel1.Controls.Add(new LoginLeftSideButtons());
            // Add Login form to Panel2
            Program.myForm.splitContainer1.Panel2.Controls.Add(new Login());
        }

        // Will exit the application
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
