using System;

namespace L2_CyclicRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            var tab = new [] { 3, 8, 9, 7, 6};

            Test(tab, 1);
            Test(tab, 2);
            Test(tab, 3);
            Test(tab, 4);
            Test(tab, 5);
            Test(tab, 6);
            Test(tab, 0);
            Test(new []{1}, 1);
            Test(new int[0], 1);
        }

        private static void Test(int[] tab, int k)
        {
            var s = new Solution();
            Console.WriteLine($"Array: [{string.Join(", ", tab)}]; Rotation factor: {k}");
            Console.WriteLine(string.Join(", ", s.solution(tab, k)));
        }
    }
}
