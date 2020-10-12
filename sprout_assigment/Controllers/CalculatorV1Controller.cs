using Microsoft.AspNetCore.Mvc;

namespace sprout_assigment.Controllers
{
    [Route("api/v{version:apiVersion}/calculator")]
    [ApiController]
    [ApiVersion("2.0")]
    public class CalculatorV1Controller : BaseCalculatorController
    {
        public CalculatorV1Controller() : base(new calculator.CalculatorV1())
        { }
    }
}
