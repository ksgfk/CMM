using System;

namespace CMM.Lang
{
    public class AddSubExpr : BinaryExpr<double>
    {
        private readonly char _op;

        public AddSubExpr(Expression<double> left, Expression<double> right, char op) : base(left, right)
        {
            if (op != '+' && op != '-')
            {
                throw new ArgumentException($"加减表达式的运算符只能是'+'或'-'，不能是'{op}'");
            }

            _op = op;
        }

        public override double GetResultWithType()
        {
            return _op switch
            {
                '+' => Left.GetResultWithType() + Right.GetResultWithType(),
                '-' => Left.GetResultWithType() - Right.GetResultWithType(),
                _ => throw new ArgumentException()
            };
        }
    }
}