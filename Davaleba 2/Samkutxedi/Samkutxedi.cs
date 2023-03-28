using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samkutxedi
{
    internal class Samkutxedi
    {
        public int gverdi_1;
        private int gverdi_2;
        protected int gverdi_3;

        public Samkutxedi(int gverdi_1, int gverdi_2, int gverdi_3)
           {
            this.gverdi_1 = gverdi_1;
            this.gverdi_2 = gverdi_2;
            this.gverdi_3 = gverdi_3;
           }
    }

    class Samkutxedi2 : Samkutxedi
    {
        private int perimetri;
        private double fartobi;

        public Samkutxedi2 (int gverdi_1, int gverdi_2, int gverdi_3) : base(gverdi_1, gverdi_2, gverdi_3)
        {
            perimetri = gverdi_1 + gverdi_2 + gverdi_3;
            fartobi = gverdi_1 * gverdi_3 / 2.0;
        }

        public double Fartobi(int gverdi_1, int gverdi_3)
        {
            fartobi = gverdi_1 * gverdi_3 / 2.0;
            return fartobi;
        }

       public int Perimetri(int gverdi_1, int gverdi_2, int gverdi_3)
        {
            perimetri = gverdi_1 + gverdi_2 + gverdi_3;
            return perimetri;

        }
    }


}
