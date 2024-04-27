using Calculator.Models;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Game()
        {
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Calculate(CalculatorModel model) {

            if (!ModelState.IsValid)
                return View("Index", model);

            double result = PerformCalculation(model);
            ViewBag.Result = result;
            return View("Index", model);
        }

        private double PerformCalculation(CalculatorModel model)
        {
            switch (model.Operator)
            {
                case "+":
                    return model.Operandus1 + model.Operandus2;
                case "-":
                    return model.Operandus1 - model.Operandus2;
                case "*":
                    return model.Operandus1 * model.Operandus2;
                case "/":
                    return model.Operandus1 / model.Operandus2;
                case "%":
                    return model.Operandus1 % model.Operandus2;
                default:
                    throw new ArgumentException("Invalid operator!");
            }
        }
    }
}
