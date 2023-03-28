using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AirPlan
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

        private void button1_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e, label5);
        }

        private void button1_Click(object sender, EventArgs e, System.Windows.Forms.Label label5)
        {
            double gasTank, milage;
            int passangers, tickets;

            gasTank = double.Parse(textBox1.Text);
            milage = double.Parse(textBox2.Text);
            passangers = int.Parse(textBox3.Text);
            tickets = int.Parse(textBox4.Text);

            Airplan obj_result = new Airplan(gasTank, milage, passangers, tickets);
            obj_result.showRes(label5);

        }
    }
}
