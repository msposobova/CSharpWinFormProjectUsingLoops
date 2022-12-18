using System;
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
    public partial class frmSumNumbers : Form
    {
        public frmSumNumbers()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            lblDisplay.Controls.Clear();

            bool isNumber = int.TryParse(txtNumber.Text, out int number);
            if (!isNumber)
            {
                MessageBox.Show("Please enter a valid whole number in the box.", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumber.Focus();
                txtNumber.SelectAll();
                return;
            }

            if (number < 1 || number > 100)
            {
                MessageBox.Show("Please enter a valid whole number between 1 and 100 in the box.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumber.Focus();
                txtNumber.SelectAll();
                return;
            }
            uint result = Convert.ToUInt32(0);
            for (int x = 1; x <= number; x++)
            {
                result += Convert.ToUInt32(x);

                lblDisplay.Text = "The sum of numbers from 1 to " + number.ToString() + " is " + result.ToString();
            }
        }
    }
}
