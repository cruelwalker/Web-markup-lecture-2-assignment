using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            const int basic = 12;
            //input
            int age = int.Parse(txtAge.Text);
            //define the age range
            if (age < 5)
            {
                lblPrice.Text = "0.00";
            }
            else if (age>=5 && age <= 12)
            {
                double price = 0.5 * basic;
                lblPrice.Text = price.ToString("0.00");
            }
            else if (age>=13 && age <= 54)
            {
                lblPrice.Text = basic.ToString();
            }
            else
            {
                lblPrice.Text = "0.00";
            }
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
