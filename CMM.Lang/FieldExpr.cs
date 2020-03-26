namespace CMM.Lang
{
    public class FieldExpr : Expression<int>
    {
        private readonly IExpression _expr;

        public string FieldName { get; }

        public FieldExpr(string fieldName, IExpression expr)
        {
            FieldName = fieldName;
            _expr = expr;
        }

        public override int GetResultWithType() { return _expr == null ? 0 : 1; }
    }
}