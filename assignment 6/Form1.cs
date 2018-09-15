using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtSeconds_TextChanged(object sender, EventArgs e)
        {
            string seconds = txtSeconds.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string seconds = txtSeconds.Text;
            int numberSeconds = int.Parse(seconds);

            int numberHours = numberSeconds / 3600;
            int numberMinutes = (numberSeconds - (numberHours * 3600)) / 60;

            int x = numberHours * 3600;
            int y = (numberSeconds - x);
            // y - (x * 60) = the remider (seconds)
            int finalSeconds = y - (numberMinutes * 60);

            lblHour.Text = numberHours.ToString("00") + " : "
                + numberMinutes.ToString("00") + " : " + finalSeconds.ToString("00");


        }

        private void lblHour_Click(object sender, EventArgs e)
        {

        }
    }
}
