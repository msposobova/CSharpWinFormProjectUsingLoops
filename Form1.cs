﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoopLabReport
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            new frmSumNumbers().Show();
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            new frmSpeedDistance().Show();
        }
    }
}
