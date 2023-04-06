using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET_GET
{
    internal class Class1
    {
        private int cvladi;
        public int this[int cvladi]
        {
            get
            {
                return cvladi ^ 2;
            }

            set 
            { 
                cvladi ^= value;
            }
        }

    }
}
