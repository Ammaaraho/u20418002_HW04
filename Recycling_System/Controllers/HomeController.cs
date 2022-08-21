using u20418002_HW04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace u20418002_HW04.Controllers
{
    public class HomeController : Controller
    {
        // Repository 
       
        public ActionResult Index()
        {
            return View();
        }

        //Action that will be created and associated the views and passing paramaters from classes views and controller
        //this is a method that is calling recycles to return a list back to the home views 
        public ActionResult Home()
        {
           
            return View(List.Recycles());
        }

        public ActionResult NonRenewableEnergy()
        {
            
            return View();
        }
        public ActionResult RenewableEnergy()
        {

            return View();
        }

        [HttpPost]
        //Collects input from nonrenewable views stores them in varibles which transfer parameters to the methods being called
        public ActionResult NonRenewableEnergy(string sponsor, int watts, int charge, string nonRenewableType, string compounds, int energyGrade)
        {
            Random random = new Random();
            int id = random.Next(1, 10000000);
            //id is generated at random because a nonrenewable entry has a unique code or primary key
            NonRenewableEnergy nonRenewableEnergy = new NonRenewableEnergy(id, sponsor, watts, charge, nonRenewableType, compounds, energyGrade);
              //values are passed through objects and class as a list of attributes into nonrenewable  which is passed to a view
            List.Add(nonRenewableEnergy);
            
            return View();
        }

        [HttpPost]
        public ActionResult RenewableEnergy(string sponsor, int watts, int charge, double conductability, string renewableEnergyType)
        {
            int id = 0;
            //id is generated as chronologically because a nonrenewable entry has a unique code or primary key
            RenewableEnergy renewableEnergy = new RenewableEnergy(id, sponsor, watts, charge, renewableEnergyType, conductability);
            //values are passed through objects and class as a list of attributes into nonrenewable  which is passed to a view
            List.Add(renewableEnergy);
            //increment id to the next value
            id++;
            return View();
        }
        //action to delete entry using the id 
        public ActionResult Delete(int id)
        {
            List.Delete(id);
           return RedirectToAction("Home");
        }

        //Action to edit thhe non renewable view using the unique id
        public ActionResult EditNonEntry(int id)
        {

            NonRenewableEnergy nonRenewableEnergy = (NonRenewableEnergy)List.recycles.FirstOrDefault(x => x.RecycleID == id);
            return View(nonRenewableEnergy);
        }
        //Action to edit thhe  renewable view using the unique id
        public ActionResult EditreEntry(int id)
        {

            RenewableEnergy renewableEnergy = (RenewableEnergy)List.recycles.FirstOrDefault(x => x.RecycleID == id);
            return View(renewableEnergy);
        }

        [HttpPost]
        public ActionResult EditreEntry(RenewableEnergy renewableEnergy)
        {
            List.Edit(renewableEnergy);

            return RedirectToAction("Home");
        }

        [HttpPost]
        public ActionResult EditNonEntry(NonRenewableEnergy nonRenewableEnergy)
        {
            List.Edit(nonRenewableEnergy);

            return RedirectToAction("Home");
        }

        public ActionResult ViewEnergy()
        {
            ViewBag.Message = "Your contact page.";

            return RedirectToAction("Home");
        }
    }
}