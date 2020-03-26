using System;
using System.Threading;
using Antlr4.Runtime;
using CMM.Lang;

namespace CMM
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var visitor = new CmmExprVisitor();

            while (true)
            {
                if (!Console.KeyAvailable)
                {
                    Thread.Sleep(10);
                    continue;
                }

                var input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                var stream = new AntlrInputStream(input);
                var lexer = new CMMLexer(stream);
                var tokens = new CommonTokenStream(lexer);
                var parser = new CMMParser(tokens);
                var tree = parser.expression();
                //var expr = visitor.Visit(tree);
                //Console.WriteLine(tree.ToStringTree(parser));
                //Console.WriteLine(expr.GetResult());
                visitor.Visit(tree);
            }
        }
    }
}