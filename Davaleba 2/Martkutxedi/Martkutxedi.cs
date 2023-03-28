using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martkutxedi
{
    internal class Martkutxedi
    {
        protected int fudze;

        public Martkutxedi(int fudze)
        {
            this.fudze = fudze;
        }

    }

    class Martkutxedi2 : Martkutxedi
    {
        public int simagle;
        private int fartobi;

        public  Martkutxedi2 (int fudze, int simagle) : base (fudze)
        {
            this.simagle = simagle;
        }

        public int gamotvla(int fudze, int simagle)
        {
            fartobi = fudze * simagle; 
            return fartobi;

        }
    }

}
