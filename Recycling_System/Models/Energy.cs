using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20418002_HW04.Models
{
    public abstract class Energy

    {    //parent class 
        // are the parameters for the constructor of the class; they are omitted if the class has no parameters.
        // An instance variable is declared as follows:
        //public get and set methods, through properties, to access and update the value of a private field

        public int RecycleID { get; set; }  //objects of the class being constructed 
        public string Sponsor { get; set; } 
        public double Watts { get; set; }
        public int Charge { get; set; }


        //Constructors can also take parameters, which is used so that i can assign inital values 
        public Energy(int recycleID, string sponsor, double watts, int charge)
        {
            RecycleID = recycleID; //data members that the parmeters are passed in
            Sponsor = sponsor;    
            Watts = watts;
            Charge = charge;

        }
        public Energy() { }   

        public abstract double CalculateCost();  //by using the abstract key word n the base class it forces the derivedclass to implement the calculatecost mehtod 

        public virtual double AccumulatedCost()   //using the virtual key word, can override this method
        {
          return Charge * Watts;
        }




    }
}