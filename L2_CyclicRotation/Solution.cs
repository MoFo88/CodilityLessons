using System.Linq;

namespace L2_CyclicRotation
{
    class Solution
    {
        // 100% solution
        public int[] solution(int[] A, int K)
        {
            if (A.Any())
            {
                var length = A.Length;
                var properK = K >= length ? K % length : K;

                var begining = A.Take(A.Length - properK);
                var ending = A.Skip(A.Length - properK);

                return ending.Concat(begining).ToArray();
            }
            return new int[0];
        }
    }
}