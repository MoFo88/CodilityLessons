using System;

namespace BinaryGap
{
    class Program
    {
        static void Main(string[] args)
        {            
            test(9);
            test(529);
            test(20);
            test(15);
            test(0);
            test(-1);
        }

        private static void test(int n)
        {
            var s = new Solution();
            Console.WriteLine($"n: {n} Binary : {Convert.ToString(n, 2)}");
            Console.WriteLine(s.solution(n));
        }
    }
}
