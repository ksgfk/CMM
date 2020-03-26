namespace CMM.Lang
{
    public class AssignExpr : Expression<double>
    {
        private readonly FieldExpr _field;
        private readonly Expression<double> _expr;

        public AssignExpr(FieldExpr field, Expression<double> expr)
        {
            _field = field;
            _expr = expr;
        }

        public override double GetResultWithType() { return _expr.GetResultWithType(); }
    }
}