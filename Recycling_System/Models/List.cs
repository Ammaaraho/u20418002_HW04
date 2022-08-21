using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20418002_HW04.Models
{
    public static class List
    {
        public static readonly List<Energy> recycles = new List<Energy> ();

        public static void Add(Energy recycle)
        {
            recycles.Add(recycle);
        }

        public static List<Energy> Recycles()
        {
            return recycles;
        }

        public static void Delete(int id)
        {
           for(int i = 0; i < recycles.Count; i++)
            {
                if (recycles[i].RecycleID == id)
                {
                    recycles.Remove(recycles[i]);
                }
            }
          
        }

        public static void Edit(Energy recycle)  //the couter starts at 0 it will
        {
            if(recycle.GetType () == typeof(NonRenewableEnergy))
            {
                NonRenewableEnergy nonRenewableEnergy = (NonRenewableEnergy)recycle;
                for(int i = 0; i < recycles.Count; i++)
                {
                    if(recycles[i].RecycleID == nonRenewableEnergy.RecycleID)
                    {
                        recycles[i] = nonRenewableEnergy;
                    }
                }
               

            }

            if (recycle.GetType() == typeof(RenewableEnergy))
            {
                RenewableEnergy renewable = (RenewableEnergy)recycle;
                for (int i = 0; i < recycles.Count; i++)
                {
                    if (recycles[i].RecycleID == renewable.RecycleID)
                    {
                        recycles[i] = renewable;
                    }
                }


            }

        }
    }
}