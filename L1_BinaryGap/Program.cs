using System;

namespace L1_BinaryGap
{
    class Program
    {
        static void Main(string[] args)
        {            
            Test(9);
            Test(529);
            Test(20);
            Test(15);
            Test(0);
            Test(-1);
        }

        private static void Test(int n)
        {
            var s = new Solution();
            Console.WriteLine($"n: {n} Binary : {Convert.ToString(n, 2)}");
            Console.WriteLine(s.solution(n));
        }
    }
}
