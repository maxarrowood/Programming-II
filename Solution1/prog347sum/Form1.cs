using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace prog347sum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = Interaction.InputBox("Enter A Positive Integer:", "Enter #");
            int y = Int32.Parse(x);
            int sum = 0;
            while (y > 0)
            {
                sum += y;
                y = y - 1;
            }

            if (y < 0)
            {
                string message1 = "Enter a postive integer";
                MessageBox.Show(message1);
            }
            else
            {
                string message2 = "The sum of the numbers is " + sum.ToString();
                MessageBox.Show(message2);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
