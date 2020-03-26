using System;

namespace CMM.Lang
{
    public class CmmExprVisitor : CMMBaseVisitor<IExpression>
    {
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

        public override IExpression VisitField(CMMParser.FieldContext context)
        {
            return new FieldExpr(
                context.GetChild(0).GetText(),
                VisitExpression(context.GetChild(2) as CMMParser.ExpressionContext));
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

            var field = context.field();
            if (field != null)
            {
                return VisitField(field);
            }

            return VisitExpression((CMMParser.ExpressionContext) context.GetChild(1));
        }
    }
}