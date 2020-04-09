using System.Collections.Generic;
using System.Linq.Expressions;
using Antlr4.Runtime;

namespace CMM.Lang
{
    public class CmmExprVisitor : CMMBaseVisitor<Expression>
    {
        private readonly Dictionary<string, Expression> _fields;

        public CmmExprVisitor() { _fields = new Dictionary<string, Expression>(); }

        public override Expression VisitInt(CMMParser.IntContext context)
        {
            return Expression.Constant(int.Parse(context.GetText()), typeof(int));
        }

        public override Expression VisitFloat(CMMParser.FloatContext context)
        {
            var text = context.GetText();
            return Expression.Constant(float.Parse(text.Substring(0, text.Length - 1)), typeof(float));
        }

        public override Expression VisitDouble(CMMParser.DoubleContext context)
        {
            var text = context.GetText();
            var sign = text[text.Length - 1];
            if (sign == 'd' || sign == 'D')
            {
                text = text.Substring(0, text.Length - 1);
            }

            return Expression.Constant(double.Parse(text), typeof(double));
        }

        public override Expression VisitNum(CMMParser.NumContext context) { return context.GetChild(0).Accept(this); }

        public override Expression VisitAdd(CMMParser.AddContext context)
        {
            GetBinaryExprLeftRight(context.Parent, out var left, out var right);
            return Expression.Add(left, right);
        }

        public override Expression VisitSub(CMMParser.SubContext context)
        {
            GetBinaryExprLeftRight(context.Parent, out var left, out var right);
            return Expression.Subtract(left, right);
        }

        public override Expression VisitAddSub(CMMParser.AddSubContext context)
        {
            return context.GetChild(1).Accept(this);
        }

        public override Expression VisitMul(CMMParser.MulContext context)
        {
            GetBinaryExprLeftRight(context.Parent, out var left, out var right);
            return Expression.Multiply(left, right);
        }

        public override Expression VisitDiv(CMMParser.DivContext context)
        {
            GetBinaryExprLeftRight(context.Parent, out var left, out var right);
            return Expression.Divide(left, right);
        }

        public override Expression VisitMulDiv(CMMParser.MulDivContext context)
        {
            return context.GetChild(1).Accept(this);
        }

        private void GetBinaryExprLeftRight(RuleContext context, out Expression left, out Expression right)
        {
            left = context.GetChild(0).Accept(this);
            right = context.GetChild(2).Accept(this);
        }

        public override Expression VisitVariable(CMMParser.VariableContext context)
        {
            var text = context.GetText();
            if (_fields.TryGetValue(text, out var expr))
            {
                return expr;
            }

            _fields.Add(text, null);
            return null;
        }

        public override Expression VisitField(CMMParser.FieldContext context) { return _fields[context.GetText()]; }

        public override Expression VisitAssign(CMMParser.AssignContext context)
        {
            var text = context.GetChild(0).GetText();
            var expr = Visit(context.GetChild(2));
            if (_fields.ContainsKey(text))
            {
                _fields[text] = expr;
            }
            else
            {
                _fields.Add(text, expr);
            }

            return expr;
        }

        public override Expression VisitOperatorAssign(CMMParser.OperatorAssignContext context)
        {
            return context.GetChild(1).Accept(this);
        }
    }
}