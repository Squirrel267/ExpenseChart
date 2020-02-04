using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Charts.Models;


namespace Charts.Controllers
{
    public class ChartController: Controller
    {
        [HttpGet]
        public IActionResult CalculationOfTheInterest()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CalculationOfTheInterest(int food, int car,int trasport,int loans,int utilities,int other)
        {
            double perFood, perCar, perTrasport, perLoans, perUtilities, perOther;
            int amount = food + car + trasport + loans + utilities + other;
            perFood = (food * 100) / amount;
            perCar = (car * 100) / amount;
            perTrasport = (trasport * 100) / amount;
            perLoans = (loans * 100) / amount;
            perUtilities = (utilities * 100) / amount;
            perOther = (other * 100) / amount;
            Costs costs = new Costs() { PerCar = perCar, PerFood = perFood ,PerTransport=perTrasport,
                PerLoans=perLoans,PerUtilities =perUtilities,PerOther =perOther,
                Food =food,Car=car ,Transport=trasport, Loans= loans,Utilities=utilities,Other=other};
            return View("Chart",costs);
        }
        public IActionResult Chart()
        {
            return View();
        }

    }
    
}
