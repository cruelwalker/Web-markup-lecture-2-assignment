using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_8._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            string totallbl = lblTotal.Text;
            string vatlbl = lblVat.Text;
            string pricelbl = lblPrice.Text;
            string nJeans = txtNjeans.Text;
            string nOfShirts = txtNtshirts.Text;
            double shirts = double.Parse(nOfShirts);
            double jeans = double.Parse(nJeans);

            double jeansPrice = jeans * 100;
            double shirtsPrice = shirts * 30;
            double price = jeansPrice + shirtsPrice;
            double vat = price * 0.21;
            double totalPrice = vat + price;

            lblPrice.Text = ("$") + price.ToString(".00");
            lblVat.Text = ("$") + vat.ToString(".00");
            lblTotal.Text = ("$") +  totalPrice.ToString(".00");
            lblTime.Text = DateTime.Now.ToString("HH:mm: dd-MM-yyyy");

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string nOfShirts = txtNtshirts.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string nJeans = txtNjeans.Text;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            string pricelbl = lblPrice.Text;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            string totallbl = lblTotal.Text;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            string vatlbl = lblVat.Text;
        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm: dd-MM-yyyy");
        }
    }
}
