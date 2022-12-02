using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment12_AlekseiPant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void displayBtn(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int number = (int)0;
            int shiftNumber = (int)0;
            decimal hourlyPayRate = (decimal)0;

            if (!string.IsNullOrEmpty(name) &&
                int.TryParse(txtNumber.Text, out number) &&
                int.TryParse(txtShiftNumber.Text, out shiftNumber) &&
                decimal.TryParse(txtHourlyPayRate.Text, out hourlyPayRate))
            {
                ProductionWorker worker = new ProductionWorker(name, number, shiftNumber, hourlyPayRate);
                txtOutput.Text = worker.ToString();
            }
            else
            {
                MessageBox.Show("Incorrect input!");
            }
        }

        private void clearBtn(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtNumber.Text = "";
            txtShiftNumber.Text = "";
            txtHourlyPayRate.Text = "";
            txtOutput.Text = "";
        }
    }
}
