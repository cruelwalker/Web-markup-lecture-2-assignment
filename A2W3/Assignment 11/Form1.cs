using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSecondN_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //input
            double firstN = double.Parse (txtFirstN.Text);
            double secondN = double.Parse(txtSecondN.Text);
            //calculations
            double average = (firstN + secondN) / 2;
            //define which number is the highest
            if (firstN > secondN)
            {
                double difference = firstN - average;
                lblHigh.Text = firstN.ToString();
                lblDiff.Text = difference.ToString();
                lblAverage.Text = average.ToString();
            }
            else
            {
                double difference = secondN - average;
                lblHigh.Text = secondN.ToString();
                lblDiff.Text = difference.ToString();
                lblAverage.Text = average.ToString();
            }
        }

        private void lblHigh_Click(object sender, EventArgs e)
        {

        }

        private void lblAverage_Click(object sender, EventArgs e)
        {

        }

        private void lblDiff_Click(object sender, EventArgs e)
        {

        }
    }
}
