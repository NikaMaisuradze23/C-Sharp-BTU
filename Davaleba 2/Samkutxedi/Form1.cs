using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Samkutxedi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int gverdi_1 = 10;
            int gverdi_2 = 20;
            int gverdi_3 = 30;
            Samkutxedi2 obj_1 = new Samkutxedi2(gverdi_1,gverdi_2,gverdi_3);
            obj_1.Fartobi(gverdi_1, gverdi_3);
            obj_1.Perimetri(gverdi_1, gverdi_2, gverdi_3);
        }
    }
}
