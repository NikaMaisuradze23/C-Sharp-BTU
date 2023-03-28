using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Televizori
{
    internal class Televizori
    {
        protected int vatPerHour;
        protected int time;


        public Televizori(int vatPerHour, int time) 
        { 
            this.vatPerHour = vatPerHour;
            this.time = time;
        
        }

    }


    class Memkvidre_1 : Televizori
    {
        public int momxmarebeli;

        public Memkvidre_1(int vatPerHour, int time, int momxmarebeli) : base(vatPerHour, time)
        {
            this.momxmarebeli = momxmarebeli;

        }
        
        public void gamotana (Label lab4)
        {
            lab4.Text = "ენერგიის მოხმარება: "+ vatPerHour + "  დრო: "+ time + " დახარჯული დრო: "+ momxmarebeli;
            
        }


    }
}
