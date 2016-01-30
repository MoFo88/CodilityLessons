using System;

namespace L3_TapeEquilibrium
{
    class Program
    {
        static void Main(string[] args)
        {
            Test(new[] { 3, 1 });
            Test(new[] { -1000, 1000 });
            Test(new[] { 3, 1, 2, 4, 3 });
            Test(new[] { 9, 9, 9, 9, 9, 9 });
            Test(new[] { 9, 9, 9, 9, 9, 9, 9 });            
        }

        private static void Test(int[] tab)
        {
            var s = new Solution();
            Console.WriteLine($"Array: [{string.Join(", ", tab)}]");
            Console.WriteLine("Solution: " + s.solution(tab));
        }
    }
}
