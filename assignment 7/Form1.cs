using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string startBox = txtStart.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string endBox = txtEnd.Text;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string priceBox = txtTotal.Text;

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string startBox = txtStart.Text;
            string endBox = txtEnd.Text;
            string priceBox = txtTotal.Text;
            string priceLbl = lblPrice.Text;
            string vatLbl = lblVat.Text;
            string totalLbl = lblTotal.Text;

            /*
             * endprice - startprice = kmNeed
             * kmNeed * priceKm = price
             * 0.21 * price = vat
             * total = vat + price
            */

            double startPrice = double.Parse(startBox);
            double endPrice = double.Parse(endBox);
            double priceKm = double.Parse(priceBox);

            double kmNeed = endPrice - startPrice;
            double price = kmNeed * priceKm;
            double vat = 0.21 * price;
            double total = vat + price;

            lblPrice.Text = price.ToString("0.00");
            lblVat.Text = vat.ToString("0.00");
            lblTotal.Text = total.ToString("0.00");



        }

        private void lblPrice_Click(object sender, EventArgs e)
        {
            string priceLbl = lblPrice.Text;
        }

        private void lblVat_Click(object sender, EventArgs e)
        {
            string vatLbl = lblVat.Text;
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {
            string totalLbl = lblTotal.Text; 
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
           
            txtStart.Text  = null;
            txtEnd.Text = null;
            txtTotal.Text = null;
            lblPrice.Text = "----";
            lblVat.Text = "----";
            lblTotal.Text = "----";

        
        }
    }
}
