using System;

namespace calculator
{
    public class CalculatorBase : ICalculator
    {
        protected struct Element
        {
            public bool a;
            public bool b;
            public bool c;

            public void Deconstruct(out bool a, out bool b, out bool c)
            {
                a = this.a;
                b = this.b;
                c = this.c;
            }
        }

        public virtual CalculatorResult Get_H(bool a, bool b, bool c)
        {
            Element element = new Element
            {
                a = a, b = b, c = c
            };

            var result = element switch
            {
                Element(true, true, false) => CalculatorResult.M,
                Element(true, true, true) => CalculatorResult.P,
                Element(false, true, true) => CalculatorResult.T,
                _ => CalculatorResult.Error
            };

            return result;
        }

        public virtual float Get_K(CalculatorResult h, float d, int e, int f)
        {
            switch (h)
            {
                case CalculatorResult.M:
                    return d + (d * e / 10);
                case CalculatorResult.P:
                    return d + (d * (e - f) / 25.5f);
                case CalculatorResult.T:
                    return d - (d * f / 30);
            }

            throw new ArgumentException(string.Format("result can't be {0}", h));
        }
    }
}
