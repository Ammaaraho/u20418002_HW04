using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20418002_HW04.Models
{

    // To inherit from a class, use the : symbol.

    //In the example below, the NonRenewableEnergy class (NonRenewableEnergy) inherits the fields and methods from the Energy class (parent):
    //It is useful for code reusability: reuse fields and methods of an existing class when you create a new class.
    public class NonRenewableEnergy : Energy
    {
        public string NonRenewableType { get; set; }
        public string Compounds { get; set; }
        public int EnergyGrade{ get; set; }
        public NonRenewableEnergy(int recycleID, string sponsor, double watts, int charge, string nonRenewableType, string compounds, int energyGrade) :base(recycleID, sponsor, watts, charge) //
        {
            NonRenewableType = nonRenewableType;
            Compounds = compounds;
            EnergyGrade = energyGrade;
        }

        public NonRenewableEnergy()
        {

        }
        public override double CalculateCost()  //this is derived from the base class POLO
        {
            return 25;
        }
    }
}