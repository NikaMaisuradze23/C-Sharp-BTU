using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirPlan
{
    internal class Airplan
    {
        private double gasTank, milage;
        private int passangers, tickets;


        public Airplan(double gasTank, double milage, int passangers, int tickets)
        {
            this.gasTank = gasTank;
            this.milage = milage; 
            this.passangers = passangers; 
            this.tickets = tickets;
        }

        public void showRes(Label text_1)
        {
            text_1.Text = "მგზავრების რაოდენობა: " + gasTank.ToString() + "\n" + "მანძილი: " + milage.ToString() + "\n" + "ბილეთები: " + tickets.ToString() + "\n" + "მგზავრი: " + passangers.ToString() ;


        }

    }
}
