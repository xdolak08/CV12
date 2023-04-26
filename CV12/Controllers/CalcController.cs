using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CV12.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalcController : ControllerBase
    {
        [HttpPost(Name = "Calculate")]
        public decimal Post([FromBody] CalcDTO calcDTO)
        {
            decimal vysl = 0;
            switch (calcDTO.Operation)
            {
                case "plus":
                     vysl = Decimal.Parse((calcDTO.Operand1 + calcDTO.Operand2).ToString());
                    break;

                case "minus":
                    vysl = Decimal.Parse((calcDTO.Operand1 - calcDTO.Operand2).ToString());
                    break;

                case "krat":
                    vysl = Decimal.Parse((calcDTO.Operand1 * calcDTO.Operand2).ToString());
                    break;

                case "deleno":
                    vysl = Decimal.Parse((calcDTO.Operand1 / calcDTO.Operand2).ToString());
                    break;


            }
            return vysl;

        }
    }
    
}
