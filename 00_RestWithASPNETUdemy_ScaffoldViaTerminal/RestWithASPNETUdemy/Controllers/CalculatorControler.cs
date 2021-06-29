using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RestWithASPNETUdemy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorControler : ControllerBase
    {
        private readonly ILogger<CalculatorControler> _logger;

        public CalculatorControler(ILogger<CalculatorControler> logger)
        {
            _logger = logger;
        }
        //Sum é o metodo, first number primeiro parametro e second number segundo parametro
        [HttpGet("Sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {
            if (IsNumeric(secondNumber) && IsNumeric(firstNumber))
            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Input Invalido");
        }
        [HttpGet("Subtration/{firstNumber}/{secondNumber}")]
        public IActionResult Subtration(string firstNumber, string secondNumber)
        {
            if (IsNumeric(secondNumber) && IsNumeric(firstNumber))
            {
                var sum = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Input Invalido");
        }
        [HttpGet("Multiplication/{firstNumber}/{secondNumber}")]
        public IActionResult Multiplication(string firstNumber, string secondNumber)
        {
            if (IsNumeric(secondNumber) && IsNumeric(firstNumber))
            {
                var sum = ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Input Invalido");
        }
        [HttpGet("division/{firstNumber}/{secondNumber}")]
        public IActionResult division(string firstNumber, string secondNumber)
        {
            if (IsNumeric(secondNumber) && IsNumeric(firstNumber))
            {
                var sum = ConvertToDecimal(firstNumber) / ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Input Invalido");
        }
        [HttpGet("mean/{firstNumber}/{secondNumber}")]
        public IActionResult mean(string firstNumber, string secondNumber)
        {
            if (IsNumeric(secondNumber) && IsNumeric(firstNumber))
            {
                var sum = (ConvertToDecimal(firstNumber) / ConvertToDecimal(secondNumber))/2;
                return Ok(sum.ToString());
            }
            return BadRequest("Input Invalido");
        }
        [HttpGet("squareRoot/{firstNumber}")]
        public IActionResult sqaureRoot(string firstNumber)
        {
            if (IsNumeric(firstNumber))
            {
                var squareRoot = Math.Sqrt((double)Convert.ToDecimal(firstNumber));
                return Ok(squareRoot.ToString());
            }
            return BadRequest("Input Invalido");
        }
        private bool IsNumeric(string strNumber)
        {
            double number;
            bool isNumber= double.TryParse(strNumber, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out number);
            return isNumber;
        }

        private decimal ConvertToDecimal(string strNumber)
        {
            decimal decimalValue;
            if(decimal.TryParse(strNumber, out decimalValue))
            {
                return decimalValue;
            }
            return 0;
        }

    }
}
