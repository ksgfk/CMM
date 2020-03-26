namespace CMM.Lang
{
    public class NumberExpr : Expression<double>
    {
        private readonly double _number;

        public NumberExpr(string number) { _number = double.Parse(number); }

        public override double GetResultWithType() { return _number; }
    }
}