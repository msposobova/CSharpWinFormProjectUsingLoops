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
    public partial class frmSpeedDistance : Form
    {
        public frmSpeedDistance()
        {
            InitializeComponent();
        }

        private void txtHours_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal speed;
            int hours;
            lstDisplay.Items.Clear();

            bool isSpeed = decimal.TryParse(txtSpeed.Text, out speed);
            if (!isSpeed || speed <= 0)
            {
                MessageBox.Show("Please enter a speed value that is greater than zero", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSpeed.Focus();
                txtSpeed.SelectAll();
                return;
            }

            bool isHours = int.TryParse(txtHours.Text, out hours);
            if (!isHours || hours <= 0)
            {
                MessageBox.Show("Please enter a valid whole number for hours that is greater than zero", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHours.Focus();
                txtHours.SelectAll();
                return;
            }

            lstDisplay.Items.Add("Hours" + "\t\t" + "Distance" + Environment.NewLine);

            decimal distanceOutput = 0;
            int hoursOutput = 1;

            while (hoursOutput <= hours)
            {
                distanceOutput = speed * hoursOutput;

                lstDisplay.Items.Add(hoursOutput.ToString() + "\t\t" + distanceOutput.ToString());

                hoursOutput++;
            }

            lstDisplay.Items.Add("Your total distance travelled is " + distanceOutput.ToString());
        }
    }
}
