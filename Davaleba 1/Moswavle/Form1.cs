using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moswavle
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
            string saxeli, gvari;
            int asaki;

            saxeli = textBox1.Text;
            gvari = textBox2.Text;
            asaki = int.Parse(textBox3.Text);


            Moswavle obj_mosw = new Moswavle(gvari, saxeli, asaki);
            label4.Text = "სახელი: " + saxeli +"\n"+ " გვარი: " + gvari+"\n" + " ასაკი: " + asaki;



        }
    }
}
