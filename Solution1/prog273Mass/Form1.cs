using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prog273Mass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kgs = int.Parse(textBox1.Text);

            double newts = kgs * 9.8;

            if (newts >= 1001)
            {
                lblNewts.Text = "Product is too Heavy";
            }
            else if (newts <= 10)
            {
                lblNewts.Text = "Product is too Light";
            }
            else
            {
                lblNewts.Text = newts.ToString() + " Netwons" ;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            lblNewts.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
