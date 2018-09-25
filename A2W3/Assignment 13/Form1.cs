using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNRD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNkms_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNoLTanked_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //input
            int rentalDays = int.Parse(txtNRD.Text);
            double numberKms = double.Parse(txtNkms.Text);
            double nOfLiters = double.Parse(txtNoLTanked.Text);
            // 55 per.day / 0.25 per.100km / 2.20 per.liter
            /* days * 55 = price
             * number of km - (100*days) = the left 
             * the left * 0.25 = the plus fees
             * the plus + price = total
             */
            int Fees = rentalDays * 100;
            
             if (chRefeul.Checked)
            {
               if (Fees < numberKms)
                {
                    double price = rentalDays * 55;
                    double lefts = numberKms - (100 * rentalDays);
                    double plusFees = lefts * 0.25;
                    double liters = nOfLiters * 2.20;
                    double total = plusFees + price + liters;
                    lblPrice.Text = total.ToString("0.00");
                }
               else
                {
                    double price = rentalDays * 55;
                    double liters = nOfLiters * 2.20;
                    double total = price + liters;
                    lblPrice.Text = total.ToString("0.00");
                }
                
            }
             else
            {
                if (Fees < numberKms)
                {
                    double price = rentalDays * 55;
                    double lefts = numberKms - (100 * rentalDays);
                    double plusFees = lefts * 0.25;
                    double total = plusFees + price;
                    lblPrice.Text = total.ToString("0.00");
                }
                else
                {
                    double price = rentalDays * 55;
                    double total = price;
                    lblPrice.Text = total.ToString("0.00");
                }
                
                

            }

        }

        private void price_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
