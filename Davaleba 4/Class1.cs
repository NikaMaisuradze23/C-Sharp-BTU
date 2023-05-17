using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Davaleba12
{
    internal class Class1
    {
        public static void Metodi_1(int par1)
        {
            int ricxvi;
            int[] masivi = new int[5];
            try
            {
                switch (par1)
                {
                    case 0:
                        masivi[7] = 7; 
                        break;
                    case 1:return;
                        
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("diapazoni!!");
            }
            finally
            {
                MessageBox.Show("finally");
            }
        }
    }

}
