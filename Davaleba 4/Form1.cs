using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Davaleba12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] masivi1 = { 1, 3, 5, 7, 9 };

            label3.Text = "";

            int sum = 0;

            for (int i = 0; i < masivi1.Length; i++)
            {
                try
                {
                    sum += masivi1[i];
                    label3.Text = "ჯამი:" + sum ;

                }
                catch(IndexOutOfRangeException) {

                    label3.Text = "შეცდომა!";
                }
                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] masivi1 = { 1, 3, 5, 7, 9 };
            int[] masivi2 = { 0, 2, 4, 0, 3 };
            int[] shedegi = new int[5];
            label4.Text = "";
            for (int ind = 0; ind < masivi1.Length; ind++)
                try
                {
                    shedegi[ind] = masivi1[ind] / masivi2[ind];
                    label4.Text += masivi1[ind].ToString() + " / " +
                    masivi2[ind].ToString() + " = " + shedegi[ind].ToString() + '\n';
                }
                catch (DivideByZeroException)
                {
                    label4.Text += "ნულზე გაყოფა" + '\n';
                }
        }
    }
}
