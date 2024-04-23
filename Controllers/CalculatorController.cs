using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SOAP.Services;
namespace SOAP.Controllers
{
    [ApiController]
    [Route("Calculator")]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculatorService _calculatorService;
        public CalculatorController(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }
        [HttpPost("Add")]
        public IActionResult Add(int num1, int num2)
        {
            int result = _calculatorService.Add(num1, num2);
            return Ok(result);
        }
        [HttpPost("Subtract")]
        public IActionResult Subtract(int num1, int num2)
        {
            int result = _calculatorService.Subtract(num1, num2);
            return Ok(result);
        }

        [HttpPost("Multiply")]
        public IActionResult Multiply(int num1, int num2)
        {
            int result = _calculatorService.Multiply(num1, num2);
            return Ok(result);
        }


        [HttpPost("Divide")]
        public IActionResult Divide(int num1, int num2)
        {
            if(num2==0)
            {
                return BadRequest("Cannot divide by zero");
            }
            double result = _calculatorService.Divide(num1, num2);
            return Ok(result);
        }

    }
}