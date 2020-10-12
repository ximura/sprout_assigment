using Microsoft.AspNetCore.Mvc;

namespace sprout_assigment.Controllers
{
    [Route("api/v{version:apiVersion}/calculator")]
    [ApiController]
    [ApiVersion("1.0")]
    public class CalculatorController : BaseCalculatorController
    {
        public CalculatorController() : base(new calculator.CalculatorBase())
        { }
    }
}
