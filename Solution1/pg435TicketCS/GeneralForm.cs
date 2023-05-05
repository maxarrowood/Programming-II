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
    public partial class GeneralForm : Form
    {
        private Form myParent;
        public GeneralForm(Form prt)
        {
            InitializeComponent();
            myParent = prt;
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

        private void GeneralForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.myParent.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int tickNum = int.Parse(textBox1.Text);
            double tickTotal = 0;
            double salesTax = 0;

            if (radioButton1.Checked == true) {
                double tickTotal = tickNum * 20;
                double salesTax = tickTotal * 0.06;
            }
            else if (radioButton2.Checked == true) {
                double tickTotal = tickNum * 15;
                double salesTax = tickTotal * 0.06;
            }
            else if (radioButton3.Checked == true) {
                double tickTotal = tickNum * 10;
                double salesTax = tickTotal * 0.06;
            }

            double totCost = tickTotal + salesTax;

            label5.Text = "$" + tickTotal;
            label6.Text = "$" + salesTax;
            label7.Text = "$" + totCost;
        }
    }
}
