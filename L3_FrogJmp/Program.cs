using System;

namespace L3_FrogJmp
{
    class Program
    {
        static void Main(string[] args)
        {
            Test(10, 85, 30);
            Test(10, 100, 30);
            Test(10, 101, 30);
            Test(10, 10, 1);
        }

        private static void Test(int position, int length, int jumpLength)
        {
            var s = new Solution();
            Console.WriteLine($"Road length: {length}; Position: {position}; Jump length: {jumpLength};");
            Console.WriteLine("Solution: " + s.solution(position, length, jumpLength));
        }
    }
}
