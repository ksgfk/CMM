namespace CMM.Lang
{
    public abstract class Expression<T> : IExpression
    {
        public abstract T GetResultWithType();

        object IExpression.GetResult() { return GetResultWithType(); }
    }
}