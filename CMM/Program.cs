using System;
using System.Linq.Expressions;
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

                // var stream = new AntlrInputStream(input);
                // var lexer = new LuaLexer(stream);
                // var tokens = new CommonTokenStream(lexer);
                // var parser = new LuaParser(tokens);
                // var tree = parser.chunk();
                // Console.WriteLine(tree.ToStringTree(parser));

                var stream = new AntlrInputStream(input);
                var lexer = new CMMLexer(stream);
                var tokens = new CommonTokenStream(lexer);
                var parser = new CMMParser(tokens);
                var tree = parser.chunk();
                Console.WriteLine(tree.ToStringTree(parser));
                
                // var lexer = new CMMLexer(stream);
                // var tokens = new CommonTokenStream(lexer);
                // var parser = new CMMParser(tokens);
                // var tree = parser.expression();
                // Console.WriteLine(tree.ToStringTree(parser));
                // try
                // {
                //     var expr = visitor.Visit(tree);
                //     if (expr == null)
                //     {
                //         Console.WriteLine("null");
                //         continue;
                //     }
                //
                //     var result = Expression.Lambda(expr).Compile();
                //     Console.WriteLine(result.DynamicInvoke());
                //     // Console.WriteLine(expr.ToString());
                // }
                // catch (Exception e)
                // {
                //     Console.WriteLine(e);
                // }
            }
        }
    }
}