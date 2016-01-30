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

    class Solution
    {
        // 100% score
        public int solution(int N)
        {
            var currentGap = 0;
            var maxGap = 0;
            if (N > 0)
            {
                while (N%2 == 0)
                    N /= 2;

                while (N >= 1)
                {
                    if (N%2 == 1)
                    {
                        currentGap = 0;
                    }
                    else
                    {
                        currentGap++;
                    }

                    maxGap = maxGap <= currentGap ? currentGap : maxGap;
                    N /= 2;
                }
            }

            return maxGap;
        }
    }
}
