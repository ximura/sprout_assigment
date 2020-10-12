using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using calculator;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace sprout_assigment.Controllers
{
    public class BaseCalculatorController : ControllerBase
    {
        public BaseCalculatorController(ICalculator _calculator) : base()
        {
            calculator = _calculator;
        }
        public struct InputArg
        {
            public bool A { get; set; }
            public bool B { get; set; }
            public bool C { get; set; }
            public float D { get; set; }
            public int E { get; set; }
            public int F { get; set; }
        }

        public struct Result
        {
            [JsonConverter(typeof(StringEnumConverter))]
            public CalculatorResult H { get; set; }
            public float K { get; set; }
        }

        [HttpPost()]
        public ActionResult<Result> CalculateResult([FromBody] InputArg content)
        {
            Result result = new Result();
            result.H = calculator.Get_H(content.A, content.B, content.C);
            result.K = calculator.Get_K(result.H, content.D, content.E, content.F);

            return result;
        }

        private ICalculator calculator;
    }
}
