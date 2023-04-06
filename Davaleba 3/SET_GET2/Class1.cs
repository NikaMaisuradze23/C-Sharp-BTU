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
                if (cvladi%2 > 0)
                {
                    return cvladi;
                }
            }

            set 
            { 
                if (value%2 > 0)
                {
                    cvladi = value;
                }
            }
        }

    }
}
