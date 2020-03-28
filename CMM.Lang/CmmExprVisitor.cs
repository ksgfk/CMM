using System;
using System.Collections.Generic;

namespace CMM.Lang
{
    /// <summary>
    /// TODO：是不是用Listener来储存解析比较好，Visitor返回解析结果
    /// </summary>
    public class CmmExprVisitor : CMMBaseVisitor<IExpression>
    {
        private readonly Dictionary<string, FieldExpr> _fields;

        public CmmExprVisitor() { _fields = new Dictionary<string, FieldExpr>(); }

        public override IExpression VisitNumber(CMMParser.NumberContext context) { return new NumberExpr(context.GetText()); }

        public override IExpression VisitOperatorAddSub(CMMParser.OperatorAddSubContext context)
        {
            var parent = context.Parent;
            return new AddSubExpr(
                (Expression<double>) VisitExpression((CMMParser.ExpressionContext) parent.GetChild(0)),
                (Expression<double>) VisitExpression((CMMParser.ExpressionContext) parent.GetChild(2)),
                parent.GetChild(1).GetText()[0]);
        }

        public override IExpression VisitOperatorMulDiv(CMMParser.OperatorMulDivContext context)
        {
            var parent = context.Parent;
            return new MulDivExpr(
                (Expression<double>) VisitExpression((CMMParser.ExpressionContext) parent.GetChild(0)),
                (Expression<double>) VisitExpression((CMMParser.ExpressionContext) parent.GetChild(2)),
                parent.GetChild(1).GetText()[0]);
        }

        public override IExpression VisitOperatorAssign(CMMParser.OperatorAssignContext context)
        {
            var parent = context.Parent;
            var field = (FieldExpr) VisitField((CMMParser.FieldContext) parent.GetChild(0));
            var expr = VisitExpression((CMMParser.ExpressionContext) parent.GetChild(2));
            field.Expr = expr;
            return field;
        }

        public override IExpression VisitField(CMMParser.FieldContext context)
        {
            var fieldName = context.GetChild(0).GetText();
            if (!_fields.TryGetValue(fieldName, out var field))
            {
                field = new FieldExpr(fieldName, null);
                _fields.Add(fieldName, field);
            }

            return field;
        }

        public override IExpression VisitExpression(CMMParser.ExpressionContext context)
        {
            if (context == null)
            {
                return null;
            }

            var number = context.number();
            if (number != null)
            {
                return VisitNumber(number);
            }

            var opMd = context.operatorMulDiv();
            if (opMd != null)
            {
                return VisitOperatorMulDiv(opMd);
            }

            var opAs = context.operatorAddSub();
            if (opAs != null)
            {
                return VisitOperatorAddSub(opAs);
            }

            var assign = context.operatorAssign();
            if (assign != null)
            {
                return VisitOperatorAssign(assign);
            }

            var field = context.field();
            if (field != null)
            {
                var ans = (FieldExpr) VisitField(field);
                return ans.Expr == null ? null : ans;
            }


            if (context.GetChild(0).GetText() == "print(") //过于生草的解析方式（
            {
                Console.Write(">> ");
                var expr = VisitExpression((CMMParser.ExpressionContext) context.GetChild(1));
                if (expr == null)
                {
                    Console.WriteLine("null");
                }
                else
                {
                    Console.WriteLine(expr.GetResult());
                }
            }

            return VisitExpression((CMMParser.ExpressionContext) context.GetChild(1));
        }
    }
}