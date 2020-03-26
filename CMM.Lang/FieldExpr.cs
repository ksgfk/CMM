namespace CMM.Lang
{
    public class FieldExpr : Expression<double>
    {
        public string FieldName { get; }
        public IExpression Expr { get; set; }

        public FieldExpr(string fieldName, IExpression expr)
        {
            FieldName = fieldName;
            Expr = expr;
        }

        public override double GetResultWithType() { return ((Expression<double>) Expr).GetResultWithType(); }
    }
}