namespace calculator
{
    public class CalculatorV2 : CalculatorBase
    {
        public override CalculatorResult Get_H(bool a, bool b, bool c)
        {
            Element element = new Element
            {
                a = a,
                b = b,
                c = c
            };

            var result = element switch
            {
                Element(true, true, false) => CalculatorResult.T,
                Element(true, false, true) => CalculatorResult.M,
                _ => CalculatorResult.Error
            };

            if ( result == CalculatorResult.Error)
            {
                result = base.Get_H(a, b, c);
            }

            return result;
        }

        public override float Get_K(CalculatorResult h, float d, int e, int f)
        {
            if (h == CalculatorResult.M)
            {
                return f + d + (d * e / 100);
            }

            return base.Get_K(h, d, e, f);
        }
    }
}
