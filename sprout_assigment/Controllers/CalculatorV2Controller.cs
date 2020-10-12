using Microsoft.AspNetCore.Mvc;

namespace sprout_assigment.Controllers
{
    [Route("api/v{version:apiVersion}/calculator")]
    [ApiController]
    [ApiVersion("3.0")]
    public class CalculatorV2Controller : BaseCalculatorController
    {
        public CalculatorV2Controller() : base(new calculator.CalculatorV2())
        { }
    }
}
