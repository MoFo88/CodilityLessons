using System;

namespace L2_OddOccurrencesInArray
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Test(new[] {9, 3, 9, 3, 9, 7, 9});
            Test(new[] {9, 9, 9, 9, 9, 9, 9});
            Test(new[] { 1000000000 });
        }

        private static void Test(int[] tab)
        {
            var s = new Solution();
            Console.WriteLine($"Array: [{string.Join(", ", tab)}]");
            Console.WriteLine("Solution: " + s.solution(tab));
        }
    }
}