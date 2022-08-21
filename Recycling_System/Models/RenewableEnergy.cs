using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20418002_HW04.Models
{
    public class RenewableEnergy : Energy
    {
        public string RenewableEnergyType { get; set; }    
        public double Conductability { get; set; }
 

        public RenewableEnergy(int recycleID, string sponsor, double watts, int charge,string renewableEnergyType, double conductability) : base(recycleID, sponsor, watts, charge)
        {
            RenewableEnergyType = renewableEnergyType;
            Conductability = conductability;
           
        }

        public RenewableEnergy():base()
        {

        }

        public override double CalculateCost()  
        {
            return Conductability * 2.5; ///this is derived from the base class
        }

    }
}