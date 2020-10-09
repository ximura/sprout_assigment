namespace calculator
{
    public class CalculatorV1 : CalculatorBase
    {
        public override float Get_K(CalculatorResult h, float d, int e, int f)
        {
            if (h == CalculatorResult.P)
            {
                return 2 * d + (d * e / 100);
            }

            return base.Get_K(h, d, e, f);
        }
    }
}
