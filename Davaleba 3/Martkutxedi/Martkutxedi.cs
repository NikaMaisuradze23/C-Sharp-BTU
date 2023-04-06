using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Martkutxedi
{
    internal class Martkutxedi
    {
        public static int gverdi1, gverdi2;
        public int perimetri;

        public Martkutxedi(int gverdi1, int gverdi2)
        {
            gverdi1 = gverdi1;
            gverdi2 = gverdi2;
            
        }

        private int Perimetri(int gverdi1,int gverdi2, Label labl)
        {
            perimetri = (gverdi1 + gverdi2) * 2;
            return perimetri;
        }

        public static void Gacemis_metodi()
        {
            Martkutxedi obj = new Martkutxedi();
            obj.Perimetri();
        }

      
    }
}
