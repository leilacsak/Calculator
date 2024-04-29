﻿using Calculator.Models;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Game(CalculatorModel model)
        { 
            return View(model);
        }
        

        [HttpPost]
        public IActionResult Calculate(CalculatorModel model) {

            if (!ModelState.IsValid)
                return View("Game", model);

            double result = PerformCalculation(model);
            model.Result = result;
            return View("Game", model);
        }

        private double PerformCalculation(CalculatorModel model)
        {
            return model.Operator switch
            {
                "+" => model.Operandus1 + model.Operandus2,
                "-" => model.Operandus1 - model.Operandus2,
                "*" => model.Operandus1 * model.Operandus2,
                "/" => model.Operandus1 / model.Operandus2,
                "%" => model.Operandus1 % model.Operandus2,
                _ => throw new ArgumentException("Invalid operator!"),
            };
        }
    }
}
