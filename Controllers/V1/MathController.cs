using Microsoft.AspNetCore.Mvc;
using RestWithASPNET10.Service;
using RestWithASPNET10.Utils;

namespace RestWithASPNET10.Controllers.V1
{
    [ApiController]
    [Route("[controller]")]
    public class MathController : ControllerBase
    {
        public static MathService _mathService;

        public MathController(MathService mathService)
        {
            _mathService = mathService;
        }


        [HttpGet("sum/{primeiroNumero}/{segundoNumero}")]
        public IActionResult Get(string primeiroNumero, string segundoNumero)
        {
            var valor = 0.0;


            if (NumberHelper.IsNumeric(primeiroNumero) && NumberHelper.IsNumeric(segundoNumero))
            {
                var sum = _mathService.Sum(NumberHelper.ConvertToDecimal(primeiroNumero), NumberHelper.ConvertToDecimal(segundoNumero));
                return Ok(sum);
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("subtracao/{primeiroNumero}/{segundoNumero}")]
        public IActionResult GetSub(string primeiroNumero, string segundoNumero)
        {
            var valor = 0.0;

            if (NumberHelper.IsNumeric(primeiroNumero) && NumberHelper.IsNumeric(segundoNumero))
            {
                var subtracao = _mathService.Subtracao(NumberHelper.ConvertToDecimal(primeiroNumero), NumberHelper.ConvertToDecimal(segundoNumero));
                return Ok(subtracao);
            }

            return BadRequest("Valor Invalido");
        }
    }
}
