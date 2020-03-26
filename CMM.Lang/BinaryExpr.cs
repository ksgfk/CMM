namespace CMM.Lang
{
    public abstract class BinaryExpr<T> : Expression<T>
    {
        protected readonly Expression<T> Left;
        protected readonly Expression<T> Right;

        protected BinaryExpr(Expression<T> left, Expression<T> right)
        {
            this.Left = left;
            Right = right;
        }
    }
}