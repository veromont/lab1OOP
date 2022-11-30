using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelLite.Calculator
{
    class AntlrCalcVisitor : AntlrCalcBaseVisitor<double>
    {
        public override double VisitCompileUnit(AntlrCalcParser.CompileUnitContext context)
        {
            return Visit(context.expression());
        }
        public override double VisitNumberExpr(AntlrCalcParser.NumberExprContext context)
        {
            var result = double.Parse(context.GetText());
            Debug.WriteLine(result);
            return result;
        }
        //IdentifierExpr
        public override double VisitIdentifierExpr(AntlrCalcParser.IdentifierExprContext context)
        {    
            var result = context.GetText();
            double value;
            //видобути значення змінної з таблиці
            //if (tableIdentifier.TryGetValue(result.ToString(), out value))
            if (TableStorage.Table == null)
            {
                TableStorage.Table = new TableManager(FileReader.Tab);
            }

            Cell c = TableStorage.Table.GetCell(result);
            return c.Value;
        }
        public override double VisitParenthesizedExpr(AntlrCalcParser.ParenthesizedExprContext context)
        {
            return Visit(context.expression());
        }
        public override double VisitExponentialExpr(AntlrCalcParser.ExponentialExprContext context)
        {
            var left = WalkLeft(context);
            var right = WalkRight(context);
            Debug.WriteLine("{0} ^ {1}", left, right);
            return System.Math.Pow(left, right);
        }
        public override double VisitAdditiveExpr(AntlrCalcParser.AdditiveExprContext context)
        {
            var left = WalkLeft(context);
            var right = WalkRight(context);
            if (context.operatorToken.Type == AntlrCalcLexer.ADD)
            {
                Debug.WriteLine(" {0} + {1} ", left, right);
                return left + right;
            }
            else //AntlrCalcLexer.SUBTRACT
            {
                Debug.WriteLine("{0} - {1}", left, right);
                return left - right;
            }
        }
        public override double VisitMultiplicativeExpr(AntlrCalcParser.MultiplicativeExprContext context)
        {
            var left = WalkLeft(context);
            var right = WalkRight(context);
            if (context.operatorToken.Type == AntlrCalcLexer.MULTIPLY)
            {
                Debug.WriteLine("{0} * {1}", left, right);
                return left * right;
            }
            else //AntlrCalcLexer.DIVIDE
            {
                Debug.WriteLine("{0} / {1}", left, right);
                return left / right;
            }
        }
    private double WalkLeft(AntlrCalcParser.ExpressionContext context)
    {
    return Visit(context.GetRuleContext< AntlrCalcParser.ExpressionContext>(0));
    }
    private double WalkRight(AntlrCalcParser.ExpressionContext context)
    {
        return Visit(context.GetRuleContext <AntlrCalcParser.ExpressionContext>(1));
    }
}
}