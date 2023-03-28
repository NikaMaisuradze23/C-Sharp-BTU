using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Televizori
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vatPerHour, time, momxmarebeli;

            vatPerHour = int.Parse(textBox1.Text);
            time = int.Parse(textBox2.Text);
            momxmarebeli = int.Parse(textBox3.Text);

            Memkvidre_1 obj_1 = new Memkvidre_1(vatPerHour, time, momxmarebeli);
            obj_1.gamotana(label4);

        }
    }
}
