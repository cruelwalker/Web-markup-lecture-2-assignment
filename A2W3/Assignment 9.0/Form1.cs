using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_9._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //inputs 
            string football = rkFootball.Text;
            string handball = rkHandball.Text;
            string sAge = txtAge.Text;
            string sMember = txtMember.Text;
            double age = int.Parse(sAge);
            double member = int.Parse(sMember);
            string sPrice = lblPrice.Text;


            double price;
            //Football checked 
           // difference between ages and genders and years range
            if (rkFootball.Checked)
            {
                price = 175;
             if (age > 40 && member > 10)
                {
                    price = price - 45;
                    lblPrice.Text = "€"+price.ToString("0.00");
                }   
             else if (member > 10)
                {
                    price = price - 20;
                    lblPrice.Text = "€"+price.ToString("0.00");
                } 
             else if (age>40)
                {
                    price = price - 25;
                    lblPrice.Text = "€"+price.ToString("0.00");
                }
             else
                {
                    price = 175;
                    lblPrice.Text = "€"+ price.ToString("0.00");
                }
            }
            //handball checked
            if (rkHandball.Checked)
            {
                price = 225;
                if (age > 40 && member > 10)
                {
                    price = price - 45;
                    lblPrice.Text = "€"+price.ToString("0.00");
                }
                else if (member > 10)
                {
                    price = price - 20;
                    lblPrice.Text = "€"+ price.ToString("0.00");
                }
                else if (age > 40)
                {
                    price = price - 25;
                    lblPrice.Text = "€"+ price.ToString("0.00");
                }
                else
                {
                    price = 225;
                    lblPrice.Text = "€"+price.ToString("0.00");
                }
            }

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
