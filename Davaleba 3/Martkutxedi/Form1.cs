using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Martkutxedi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gverdi1, gverdi2;
            gverdi1 = int.Parse(textBox1.Text);
            gverdi2 = int.Parse(textBox2.Text);

            Martkutxedi obj = new Martkutxedi();
            obj.Gacemis_metodi();

        }
    }
}
