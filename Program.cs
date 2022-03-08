using System;

namespace ABC // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            string sides1 = "BXDCNGRTQFJHVAOEFLPZ";
            string sides2 = "OKQPATEGDSWUINBRSYCM";
            string[] testWords = {"A", "BARK", "BOOK", "TREAT", "COMMON", "SQUAD", "CONFUSE"};

            foreach (string test in testWords) {
                ABCSolver solver = new ABCSolver(test, sides1, sides2);
                Console.WriteLine($"{test}: {solver.solve()}");
            }
        }
    }
}