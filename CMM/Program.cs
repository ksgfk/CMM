using System;
using Antlr4.Runtime;
using CMM.Lang;

namespace CMM
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var stream = new AntlrInputStream(input);
            var lexer = new CMMLexer(stream);
            var tokens = new CommonTokenStream(lexer);
            var parser = new CMMParser(tokens);
            var tree = parser.expression();
            var visitor = new CmmVisitor();
            var result = visitor.Visit(tree);
            Console.WriteLine(tree.ToStringTree(parser));
            Console.WriteLine(result);
        }
    }
}