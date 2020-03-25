using System;

namespace CMM.Lang
{
    public class CmmVisitor : CMMBaseVisitor<double>
    {
        public override double VisitNumber(CMMParser.NumberContext context) { return double.Parse(context.GetText()); }

        public override double VisitExpression(CMMParser.ExpressionContext context)
        {
            var num = context.number();
            if (num != null)
            {
                return VisitNumber(num);
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

            //GetChild<T>(int i)是第i个匹配T类型的节点，而不是第i个节点...
            //GetChild(int i)是匹配第i个节点
            return VisitExpression((CMMParser.ExpressionContext) context.GetChild(1));
        }

        public override double VisitOperatorMulDiv(CMMParser.OperatorMulDivContext context)
        {
            var par = context.Parent;
            var l = Visit(par.GetChild(0));
            var r = Visit(par.GetChild(2));
            return context.GetText() switch
            {
                "*" => l * r,
                "/" => l / r,
                _ => throw new ArgumentException()
            };
        }

        public override double VisitOperatorAddSub(CMMParser.OperatorAddSubContext context)
        {
            var par = context.Parent;
            var l = Visit(par.GetChild(0));
            var r = Visit(par.GetChild(2));
            return context.GetText() switch
            {
                "+" => l + r,
                "-" => l - r,
                _ => throw new ArgumentException()
            };
        }
    }
}