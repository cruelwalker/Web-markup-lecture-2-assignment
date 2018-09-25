using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //input 
            string sSalary = txtSalary.Text;
            double salary = double.Parse(sSalary);
            double raise = salary * 0.05;
            //calculations
            double totalSalary = salary + raise;
            //define the amount of salary
            if (raise < 75)
            {
                raise = 75;
                lblRaise.Text = "€"+" "+raise.ToString("0.00");
                lblNewS.Text = "€" +" "+ totalSalary.ToString("0.00");
            }
            else
            {
                raise = salary * 0.05;
                lblRaise.Text = "€" +" "+ raise.ToString("0.00");
                lblNewS.Text = "€" +" "+ totalSalary.ToString("0.00");
            }
        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRaise_Click(object sender, EventArgs e)
        {

        }

        private void lblNewS_Click(object sender, EventArgs e)
        {

        }
    }
}
