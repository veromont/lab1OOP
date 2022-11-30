using Antlr4.Runtime;

namespace ExcelLite.Calculator
{
    public static class Calculator
    {
        public static double Evaluate(string expression)
        {
            var lexer = new AntlrCalcLexer(new AntlrInputStream(expression));
            lexer.RemoveErrorListeners();
            lexer.AddErrorListener(new ThrowExceptionErrorListener());
            var tokens = new CommonTokenStream(lexer);
            var parser = new AntlrCalcParser(tokens);
            var tree = parser.compileUnit();
            var visitor = new AntlrCalcVisitor();
            return visitor.Visit(tree);
        }
    }
}
