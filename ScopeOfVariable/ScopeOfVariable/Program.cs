using System;

namespace ScopeOfVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 1;
            Console.WriteLine(i);
            {
                var j = 'a';
                Console.WriteLine(j);
                Console.WriteLine("khoi code ben trong " + i);
            }
            
        }
    }
}
