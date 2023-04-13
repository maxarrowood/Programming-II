using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prog54cVS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double rad = double.Parse(textBox1.Text);

            double pi = 3.14159;

            double area = pi * Math.Pow(rad, 2);
            double newarea = Math.Round(area, 3);

            double circum = 2 * pi * rad;
            double newcircum = Math.Round(circum, 3);

            label4.Text = newarea.ToString();
            label5.Text = newcircum.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label4.Text = "";
            label5.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
