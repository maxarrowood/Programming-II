using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg435TicketCS
{
    public partial class StudentForm : Form
    {
        private Form myParent;
        public StudentForm(Form prt)
        {
            InitializeComponent();
            this.myParent = prt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.myParent.Show();
            this.Close();
        }

        decimal decTAXRATE = 0.06m; // Sales Tax Rate 
        private decimal CalcText(decimal cost) {
            return cost * decTAXRATE;
        }

        private void StudentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.myParent.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ticks = int.Parse(textBox1.Text);
            int allticks = ticks * 7;
            double salesTax = allticks * 0.06;
            double totalCost = salesTax + allticks;

            label5.Text = "$" + allticks;
            label6.Text = "$" + salesTax;
            label7.Text = "$" + totalCost;
        }
    }
}
