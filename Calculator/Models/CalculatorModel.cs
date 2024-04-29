using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Calculator.Models
{
    public class CalculatorModel
    {
        [Required(ErrorMessage = "Number is required")]
        [RegularExpression(@"^\d+(\.\d+)?$", ErrorMessage = "Your input must be a number")]
        public double Operandus1 { get; set; }

        [Required(ErrorMessage = "Number is required")]
        [RegularExpression(@"^\d+(\.\d+)?$", ErrorMessage = "Your input must be a number")]
        public double Operandus2 { get;set; }

        public String? Operator { get; set; }
        public double Result { get; set; }
    }
}
