using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtLength_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBMI_Click(object sender, EventArgs e)
        {

        }

        private void lblNBMI_Click(object sender, EventArgs e)
        {

        }

        private void lblHWeight_Click(object sender, EventArgs e)
        {

        }

        private void btnCmale_Click(object sender, EventArgs e)
        {
            //input
            double weight = double.Parse(txtWeight.Text);
            double hight = double.Parse(txtLength.Text);
            //calculations
            double bmi = (weight * 10000) / (hight * hight);
            double maleH1 = ((hight * hight) * 20) / 10000;
            double maleH2 = ((hight * hight) * 25) / 10000;
            //display
            lblBMI.Text = bmi.ToString("0.0");
            lblNBMI.Text = "20..25";
            lblHWeight.Text = maleH1.ToString("0.0") +".."+ maleH2.ToString("0.0");

        }

        private void btnCfemale_Click(object sender, EventArgs e)
        {
            //inout
            double weight = double.Parse(txtWeight.Text);
            double hight = double.Parse(txtLength.Text);
            //calculation
            double bmi = (weight * 10000) / (hight * hight);
            double femaleH1 = ((hight * hight) * 19) / 10000;
            double femaleH2 = ((hight * hight) * 24) / 10000;
            //display
            lblBMI.Text = bmi.ToString("0.0");
            lblNBMI.Text = "19..24";
            lblHWeight.Text = femaleH1.ToString("0.0") + ".." + femaleH2.ToString("0.0");
        }
    }
}
