using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Calculator.Models
{
    public class CalculatorModel
    {
        [Required]
        [RegularExpression(@"^\d+(\.\d+)?$")]
        public double Operandus1 { get; set; }

        [Required]
        [RegularExpression(@"^\d+(\.\d+)?$")]
        public double Operandus2 { get;set; }

        public String? Operator { get; set; }
        public double Result { get; set; }
    }
}
